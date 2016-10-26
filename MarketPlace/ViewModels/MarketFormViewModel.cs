using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using MarketPlace.Models;

namespace MarketPlace.ViewModels
{
    public class MarketFormViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Name { get; set; }
        public int Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}