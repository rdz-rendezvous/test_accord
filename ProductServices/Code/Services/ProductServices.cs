using Microsoft.EntityFrameworkCore;
using ProductServices.Code.Interface;
using ProductServices.Entities;
using ProductServices.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.Code.Services
{
    public class ProductServices : IProductServices
    {
        private readonly ProductDbContext _dbContext;
        public async Task<List<ProductViewModel>> GetAllProductViewModel()
        {
            var result = await _dbContext.Products.ToListAsync();

            return result;
        }
        public async Task<bool> DeleteProductById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ProductViewModel> GetProductById(int id)
        {
            var result = await _dbContext.Products.Where(x=>x.ProductId == id).FirstOrDefaultAsync();

            return result;
        }

        public async Task<bool> InsertNewProduct(ProductViewModel productViewModel)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> UpdateProductById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
