using Microsoft.AspNetCore.Mvc;

namespace LegoasAssignment.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


    }
}
