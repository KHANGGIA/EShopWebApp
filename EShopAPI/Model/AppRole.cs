using Microsoft.AspNetCore.Identity;
namespace EShopAPI.Model
{
    public class AppRole :IdentityRole<Guid>
    {
        public string Description { get; set; } 
    }
}
