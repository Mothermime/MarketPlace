using MarketPlace.Models;
using MarketPlace.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Mvc;


namespace MarketPlace.Controllers
{
    public class MarketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MarketsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new MarketFormViewModel()
            {
                Categories = _context.Categories.ToList()
            };

            return View(viewModel);
        }
        [Authorize]
        [HttpPost]
        public ActionResult Create(MarketFormViewModel viewModel)

        {
            //var organiserId = 
            //var organiser = _context.Users.Single(u => u.Id == organiserId);
            //var category = _context.Categories.Single(c => c.Id == viewModel.Category);

            var market = new Market
            {
                OrganiserId = User.Identity.GetUserId(),
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                CategoryId= viewModel.Category,
                MarketName = viewModel.Name,
                Venue = viewModel.Place

            };
            _context.Markets.Add(market);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}

