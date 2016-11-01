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
        [ValidateAntiForgeryToken]
        public ActionResult Create(MarketFormViewModel viewModel)

        {
            if (!ModelState.IsValid)
            {
                viewModel.Categories = _context.Categories.ToList();
            }
            
                return View("Create", viewModel);
           
           
            var market = new Market
            {
                OrganiserId = User.Identity.GetUserId(),
                CategoryId= viewModel.Category,
                DateTime = viewModel.GetDateTime(),
                MarketName = viewModel.Name,
                Venue = viewModel.Venue

            };
            _context.Markets.Add(market);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}

