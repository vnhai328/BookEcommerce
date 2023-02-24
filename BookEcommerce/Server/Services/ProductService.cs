﻿namespace BookEcommerce.Server.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var resposne = new ServiceResponse<List<Product>>()
            {
                Data = await _context.Products.ToListAsync()
            };
            return resposne;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products.FindAsync(productId);
            if(product == null)
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
    }
}
