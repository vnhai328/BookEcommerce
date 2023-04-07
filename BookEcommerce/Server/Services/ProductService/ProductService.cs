using BookEcommerce.Server.Services.CacheService;
using BookEcommerce.Shared;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Collections.Generic;

namespace BookEcommerce.Server.Services.ProductService
{
    //reponse -> cacheData
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICacheService _cacheService;

        public ProductService(DataContext context, IHttpContextAccessor httpContextAccessor, ICacheService cacheService)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _cacheService = cacheService;
        }
        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var cacheData = _cacheService.GetData<ServiceResponse<List<Product>>>("products");

            if(cacheData != null && cacheData.Data.Count() > 0)
            {
                return cacheData;
            }

            cacheData = new ServiceResponse<List<Product>>()
            {
                Data = await _context.Products
                    .Where(p => p.Visible && !p.Deleted)
                    .Include(p => p.Variants.Where(v => v.Visible && !v.Deleted))
                    .Include(p => p.Images)
                    .ToListAsync()
            };

            var exprityTime = DateTimeOffset.Now.AddSeconds(120);
            _cacheService.SetData<ServiceResponse<List<Product>>>("products", cacheData, exprityTime);
            return cacheData;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            Product product = null;
            if (_httpContextAccessor.HttpContext.User.IsInRole("Admin"))
            {
                product = await _context.Products
                    .Include(p => p.Variants.Where(v => !v.Deleted))
                    .ThenInclude(v => v.ProductType)
                    .Include(p => p.Images)
                    .FirstOrDefaultAsync(p => p.Id == productId && !p.Deleted);
            }
            else
            {
                product = await _context.Products
                    .Include(p => p.Variants.Where(v => v.Visible && !v.Deleted))
                    .ThenInclude(v => v.ProductType)
                    .Include(p => p.Images)
                    .FirstOrDefaultAsync(p => p.Id == productId && !p.Deleted && p.Visible);
            }

            if (product == null)
            {
                response.Success = false;
                response.Messeage = "Product does not exits.";
            }
            else
            {
                response.Data = product;
            }
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var cacheData = _cacheService.GetData<ServiceResponse<List<Product>>>("getProductsByCategory");

            if(cacheData != null && cacheData.Data.Count() > 0)
            {
                return cacheData;
            }

            cacheData = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products
                    .Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower()) && p.Visible && !p.Deleted)
                    .Include(v => v.Variants.Where(v => v.Visible && !v.Deleted))
                    .Include(p => p.Images)
                    .ToListAsync()
            };
            var exprityTime = DateTimeOffset.Now.AddSeconds(90);
            _cacheService.SetData<ServiceResponse<List<Product>>>($"getProductsByCategory{categoryUrl}", cacheData, exprityTime);
            return cacheData;
        }

        public async Task<ServiceResponse<ProductSearchResult>> SearchProducts(string searchTExt, int page)
        {
            var pageResults = 3f;
            var pageCount = Math.Ceiling((await FindProductsBySearchText(searchTExt)).Count / pageResults);
            var products = await _context.Products
                                .Where(p => p.Title.ToLower().Contains(searchTExt.ToLower())||
                                    p.Description.ToLower().Contains(searchTExt.ToLower())&& 
                                    p.Visible && !p.Deleted)
                                .Include(p => p.Variants.Where(v => v.Visible && !v.Deleted))
                                .Include(p => p.Images)
                                .Skip((page - 1) * (int)pageResults)
                                .Take((int)pageResults)
                                .ToListAsync();

            var response = new ServiceResponse<ProductSearchResult>
            {
                Data = new ProductSearchResult
                {
                    Products = products,
                    CurrentPage = page,
                    Pages = (int)pageCount
                }
            };
            return response;
        }

        private async Task<List<Product>> FindProductsBySearchText(string searchTExt)
        {
            return await _context.Products
                                .Where(p => p.Title.ToLower().Contains(searchTExt.ToLower())
                                ||
                                p.Description.ToLower().Contains(searchTExt.ToLower()) 
                                && 
                                p.Visible && !p.Deleted)
                                .Include(p => p.Variants.Where(v => v.Visible && !v.Deleted))
                                .ToListAsync();
        }

        public async Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText)
        {
            var products = await FindProductsBySearchText(searchText);

            List<string> result = new List<string>();

            foreach(var product in products)
            {
                if(product.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(product.Title);
                }

                if(product.Description != null)
                {
                    var punctuation = product.Description.Where(char.IsPunctuation).Distinct().ToArray();

                    var words = product.Description.Split().Select(s => s.Trim(punctuation));

                    foreach(var word in words) 
                    {
                        if(word.Contains(searchText, StringComparison.OrdinalIgnoreCase) && !result.Contains(word))
                        {
                            result.Add(word);
                        }
                    }
                }
            }

            return new ServiceResponse<List<string>> { Data = result };
        }

        public async Task<ServiceResponse<List<Product>>> GetFeatureProducts()
        {
            var cacheData = _cacheService.GetData<ServiceResponse<List<Product>>>("getFeatureProducts");
            if(cacheData != null && cacheData.Data.Count() > 0)
            {
                return cacheData;
            }
            cacheData = new ServiceResponse<List<Product>> 
            { 
                Data = await _context.Products
                    .Where(p=>p.Featured && p.Visible && !p.Deleted)
                    .Include(p=>p.Variants.Where(v => v.Visible && !v.Deleted))
                    .Include(p => p.Images)
                    .ToListAsync()
            };

            var exprityTime = DateTimeOffset.Now.AddSeconds(90);
            _cacheService.SetData<ServiceResponse<List<Product>>>("getFeatureProducts", cacheData, exprityTime);
            return cacheData;
        }

        //Admin
        public async Task<ServiceResponse<List<Product>>> GetAdminProducts()
        {
            var cacheData = _cacheService.GetData<ServiceResponse<List<Product>>>("getAdminProducts");
            
            if(cacheData != null && cacheData.Data.Count() > 0) 
            { 
                return cacheData; 
            }

            cacheData = new ServiceResponse<List<Product>>()
            {
                Data = await _context.Products
                  .Where(p => !p.Deleted)
                  .Include(p => p.Variants.Where(v => !v.Deleted))
                  .ThenInclude(v=>v.ProductType)
                  .Include(p => p.Images)
                  .ToListAsync()
            };

            var exprityTime = DateTimeOffset.Now.AddSeconds(90);
            _cacheService.SetData<ServiceResponse<List<Product>>>("getAdminProducts", cacheData, exprityTime);

            return cacheData;
        }

        public async Task<ServiceResponse<Product>> CreateProduct(Product product)
        {
            foreach (var variant in product.Variants)
            {
                variant.ProductType = null;
            }
            var addedProduct = await _context.Products.AddAsync(product);
            var exprityTime = DateTimeOffset.Now.AddSeconds(90);
            _cacheService.SetData<ServiceResponse<Product>>($"product{product.Id}", new ServiceResponse<Product> { Data = addedProduct.Entity }, exprityTime);
            await _context.SaveChangesAsync();
            //return new ServiceResponse<Product> { Data = product };
            return new ServiceResponse<Product> { Data = addedProduct.Entity };

        }

        public async Task<ServiceResponse<Product>> UpdateProduct(Product product)
        {
            var dbProduct = await _context.Products
                .Include(p => p.Images)
                .FirstOrDefaultAsync(p => p.Id == product.Id);

            if (dbProduct == null)
            {
                return new ServiceResponse<Product>
                {
                    Success = false,
                    Messeage = "Product not found."
                };
            }

            dbProduct.Title = product.Title;
            dbProduct.Description = product.Description;
            dbProduct.ImageUrl = product.ImageUrl;
            dbProduct.CategoryId = product.CategoryId;
            dbProduct.Visible = product.Visible;
            dbProduct.Featured = product.Featured;

            var productImages = dbProduct.Images;
            _context.Images.RemoveRange(productImages);
            dbProduct.Images = product.Images;

            foreach (var variant in product.Variants)
            {
                var dbVariant = await _context.ProductVariants
                    .SingleOrDefaultAsync(v => v.ProductId == variant.ProductId && v.ProductTypeId == variant.ProductTypeId);
                if(dbVariant == null)
                {
                    variant.ProductType = null;
                    _context.ProductVariants.Add(variant);
                }
                else
                {
                    dbVariant.ProductTypeId = variant.ProductTypeId;
                    dbVariant.Price = variant.Price;
                    dbVariant.OriginalPrice = variant.OriginalPrice;
                    dbVariant.Visible = variant.Visible;
                    dbVariant.Deleted = variant.Deleted;
                }
            }

            await _context.SaveChangesAsync();
            return new ServiceResponse<Product> { Data = product };
        }

        public async Task<ServiceResponse<bool>> DeleteProduct(int productId)
        {
            var dbProduct = await _context.Products.FindAsync(productId);
            if(dbProduct == null)
            {
                return new ServiceResponse<bool>
                {
                    Success = false,
                    Data = false,
                    Messeage = "Product not found."
                };
            }          
            dbProduct.Deleted = true;
            _cacheService.RemoveData($"product{productId}");
            await _context.SaveChangesAsync();
            return new ServiceResponse<bool> { Data = true };
        }
    }
}
