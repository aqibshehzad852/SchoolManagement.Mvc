using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Mvc.Data;
using SchoolManagement.Mvc.Models;
using System.Diagnostics;


namespace SchoolManagement.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SchoolManagementDbContext _context;

        public HomeController(ILogger<HomeController> logger, SchoolManagementDbContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        
        public IActionResult Gallery()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //Email for Newsletter
        [HttpPost]
        public IActionResult Subscribe(NewsletterSubscription model)
        {
            if (ModelState.IsValid)
            {
                _context.NewsletterSubscriptions.Add(model);
                _context.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }


    }
}
