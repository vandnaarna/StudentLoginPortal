using Microsoft.AspNetCore.Mvc;
using StudentLoginPortal.Models;

namespace StudentLoginPortal.Controllers
{
    public class AdminController : Controller
    {
        private readonly DemoMvcContext _demoMvcContext = new DemoMvcContext();

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(StudentDetail student)
        {
            if (ModelState.IsValid)
            {
                _demoMvcContext.StudentDetails.Add(student);
                _demoMvcContext.SaveChanges();
            }
            return View();
        }
        public ActionResult Index(StudentDetail student)
        {
            return View();
        }
    }
}
