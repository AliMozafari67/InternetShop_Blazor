using System.ComponentModel.DataAnnotations;

namespace InternetShop_Blazor.Data.Entity
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="این فیلد نمی تواند خالی باشد")] 
        public string CategoryName { get; set; }
    }
}
