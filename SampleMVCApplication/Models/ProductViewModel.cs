using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SampleMVCApplication.Custom;

namespace SampleMVCApplication.Models
{
    public class ProductViewModel
    {
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }

        [DisplayName("Product Name")]
        public required string ProductName { get; set; }

        [DisplayName("Product Description")]
        public required string ProductDescription { get; set; }

        [DisplayName("Product Code")]
        [RegularExpression("^[a-zA-Z0-9 ]+$")]
        [CodeValidatorcs(ErrorMessage ="Product Code does not start with P character")]
        public required string ProductCode { get; set; }

        [DisplayName("Product Price")]
        [Range(10, int.MaxValue)]
        public decimal Price { get; set; }
    }
}
