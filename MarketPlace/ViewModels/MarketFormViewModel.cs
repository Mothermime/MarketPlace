using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using MarketPlace.Models;

namespace MarketPlace.ViewModels
{
    public class MarketFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Market_Name { get; set; }
        public int Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}