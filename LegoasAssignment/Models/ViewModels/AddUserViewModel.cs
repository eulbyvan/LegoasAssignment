using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LegoasAssignment.Models.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Username { get; set; }
        public string? Address { get; set; }
        public string? ZipCode { get; set; }
        public string? Province { get; set; }
        public int? RoleId { get; set; }
        public int? SelectedBranch { get; set; }
        public List<SelectListItem>? BranchesSelectList { get; set; }
        public int? ScreenId { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
