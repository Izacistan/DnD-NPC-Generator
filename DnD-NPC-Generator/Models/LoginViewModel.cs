using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace DnD_NPC_Generator.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a password.")]
        [StringLength(255)]
        public string Password { get; set; } = string.Empty;

        [ValidateNever]
        public string? ReturnUrl { get; set; } = string.Empty;

        public bool RememberMe { get; set; }
    }
}
