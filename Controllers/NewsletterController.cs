using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Mvc.Data;
using SchoolManagement.Mvc.Models;

namespace SchoolManagement.Mvc.Controllers
{
    public class NewsletterController : Controller
    {
        private readonly SchoolManagementDbContext _context;

        public NewsletterController(SchoolManagementDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public IActionResult Subscribe(NewsletterSubscription model)
        {
            if (ModelState.IsValid)
            {
               
                _context.NewsletterSubscriptions.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index", model);
        }
    }

}
