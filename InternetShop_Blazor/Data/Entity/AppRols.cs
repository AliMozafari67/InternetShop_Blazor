using Microsoft.AspNetCore.Identity;

namespace InternetShop_Blazor.Data.Entity
{
    public class AppRols: IdentityRole
    {
        public string MyRole { get; set; }
    }
}
