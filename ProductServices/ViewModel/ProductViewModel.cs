using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductServices.ViewModel
{
    //[Table("product"), Schema = "dbo"]
    public class ProductViewModel
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }

    }
}
