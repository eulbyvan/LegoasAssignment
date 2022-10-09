using System.ComponentModel.DataAnnotations;

namespace LegoasAssignment.Models.ViewModels
{
    public class UpdateUserViewModel
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Province { get; set; }
        //public int? RoleId { get; set; }
        //public int? SelectedBranch { get; set; }
        //public List<SelectListItem>? BranchesSelectList { get; set; }
        //public int? ScreenId { get; set; }
        [Required]
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; }
    }
}
