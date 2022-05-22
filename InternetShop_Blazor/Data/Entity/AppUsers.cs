using Microsoft.AspNetCore.Identity;

namespace InternetShop_Blazor.Data.Entity
{
    public class AppUsers : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
