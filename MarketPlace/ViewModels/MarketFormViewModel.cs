using MarketPlace.Models;
using System.Collections.Generic;

namespace MarketPlace.ViewModels
{
    public class MarketFormViewModel
    {
        public string Organiser { get; set; }
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Name { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}