using LegoasAssignment.Helper;
using LegoasAssignment.Models.SQLServer;
using LegoasAssignment.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LegoasAssignment.Controllers
{
    public class UsersController : Controller
    {
        private readonly LegoasDbContext legoasDbContext;

        public UsersController(LegoasDbContext legoasDbContext)
        {
            this.legoasDbContext = legoasDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddUserViewModel req)
        {
            //var branches = Branches.GetAll();

            //var branchVM = new AddUserViewModel();
            //branchVM.BranchesSelectList = new List<SelectListItem>();

            //foreach (var branch in branches)
            //{
            //    branchVM.BranchesSelectList.Add(new SelectListItem { Text = branch.Name, Value = branch.Id.ToString()});
            //}

            var user = new User()
            {
                Fullname = req.Fullname,
                Username = req.Username,
                Address = req.Address,
                ZipCode = req.ZipCode,
                Province = req.Province,
                BranchId = req.SelectedBranch
            };

            var account = new Account()
            {
                Username = req.Username,
                Password = req.Password,
                RegisterDate = DateTime.Now
            };

            await legoasDbContext.Users.AddAsync(user);
            await legoasDbContext.Accounts.AddAsync(account);
            await legoasDbContext.SaveChangesAsync();

            return RedirectToAction("Add");
        }
    }
}
