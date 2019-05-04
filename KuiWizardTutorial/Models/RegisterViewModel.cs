using System.ComponentModel.DataAnnotations;

using System.Web.Mvc;
using CompareAttribute = System.Web.Mvc.CompareAttribute;

namespace KuiWizardTutorial.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        [Remote("IsEmailJustPresent", "Home")]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}