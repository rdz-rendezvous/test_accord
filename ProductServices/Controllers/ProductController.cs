using Microsoft.AspNetCore.Mvc;
using ProductServices.Code.Interface;
using ProductServices.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        IProductServices _service;

        public ProductController(IProductServices service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var result = await _service.GetAllProductViewModel();
                
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var result = await _service.GetProductById(id);

            return Ok(result);
        }
    }
}
