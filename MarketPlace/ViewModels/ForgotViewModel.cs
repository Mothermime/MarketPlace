using System.ComponentModel.DataAnnotations;

namespace MarketPlace.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}