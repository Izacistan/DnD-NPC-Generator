using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using DnD_NPC_Generator.Services;

namespace DnD_NPC_Generator.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter a Name.")]
        [StringLength(30, ErrorMessage = "Name must be 30 characters or less.")]
        public string Name { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = string.Empty;

        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Password must meet complexity requirements.")]
        public string Password { get; set; } = string.Empty;
        public User() { }
        public List<NPC> NPCs { get; set; } = null!;
    }
}
