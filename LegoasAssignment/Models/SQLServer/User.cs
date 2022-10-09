namespace LegoasAssignment.Models.SQLServer
{
    public class User
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Province { get; set; }
        public int? RoleId { get; set; }
        public int? BranchId { get; set; }
        public int? ScreenId { get; set; }
    }
}
