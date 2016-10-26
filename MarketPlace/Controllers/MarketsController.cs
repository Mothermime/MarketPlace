using System.Linq;
using MarketPlace.Models;
using MarketPlace.ViewModels;
using System.Web.Mvc;


namespace MarketPlace.Controllers
{
    public class MarketsController : Controller
    {
        private ApplicationDbContext _context;

        public MarketsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET: Markets
        public ActionResult Create()
        {
            var viewModel = new MarketFormViewModel()
            {
                Categories = _context.Categories.ToList()
            };

            return View(viewModel);
        }
    }
}

//   
//}



//
//{
//    Categories = _context.Categories.ToList();
//}