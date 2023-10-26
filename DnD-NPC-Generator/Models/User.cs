using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using DnD_NPC_Generator.Services;

namespace DnD_NPC_Generator.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public User() { }
        public List<NPC> NPCs { get; set; } = null!;
    }
}
