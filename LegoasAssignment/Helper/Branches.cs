using LegoasAssignment.Models.SQLServer;

namespace LegoasAssignment.Helper
{
    public class Branches
    {
        public static List<Branch> GetAll()
        {
            return new List<Branch>()
            {
                new Branch(){ Id = 1, Name = "HO"},
                new Branch(){ Id = 2, Name = "CABANG1"},
                new Branch(){ Id = 3, Name = "CABANG2"},
                new Branch(){ Id = 4, Name = "CABANG3"}
            };
        }
    }
}
