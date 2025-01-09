using LeaveManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Controllers
{
    public class TestController : Controller
    {
        // GET: TestController
        // Opprinneleg ActionResult
        public IActionResult Index()
        {
            var data = new TestViewModel {
                Name = "Student",
                DateOfBirth = new DateTime(1974, 02, 25)

            };
            return View(data);
        }

    }
}
