using ProductServices.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductServices.Code.Interface
{
    public interface IProductServices
    {
        Task<List<ProductViewModel>> GetAllProductViewModel();

        Task<ProductViewModel> GetProductById(int id);
        Task<bool> InsertNewProduct(ProductViewModel productViewModel);
        Task<bool> UpdateProductById(int id);
        Task<bool> DeleteProductById(int id);
    }
}
