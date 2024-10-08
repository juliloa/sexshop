using Microsoft.AspNetCore.Identity;

namespace pj_SexShop.Models
{
    public class Users : IdentityUser
    {
        public string  FullName { get; set; }
    }
}
