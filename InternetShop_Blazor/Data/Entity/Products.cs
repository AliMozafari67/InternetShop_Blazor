using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetShop_Blazor.Data.Entity
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "این فیلد نمی تواند خالی باشد")]
        public string ProductName { get; set; }
        
        [Required]
        [Range(0,5000)]
        public double ProductPrice { get; set; }
        public byte[] ProductImage { get; set; }
        
        [Required]
        public string ProductColor { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category category { get; set; }

    }
}
