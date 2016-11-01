using MarketPlace.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MarketPlace.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcomingMarkets = _context.Markets
                .Include(m => m.Organiser)
                .Include(m => m.Category)
               
               
                .Where(m => m.DateTime > DateTime.Now);

            return View(upcomingMarkets);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}