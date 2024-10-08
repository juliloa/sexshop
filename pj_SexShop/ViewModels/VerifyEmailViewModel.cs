using System.ComponentModel.DataAnnotations;

namespace pj_SexShop.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]

        public string Email {  get; set; }
    }
}
