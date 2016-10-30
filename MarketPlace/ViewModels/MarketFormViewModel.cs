using MarketPlace.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarketPlace.ViewModels
{
    public class MarketFormViewModel
    {

        [Required]
        public string Organiser { get; set; }

        [Required]
        public string Place { get; set; }

        [Required]
        [FutureDate]
    public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public byte Category { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    

}
    }
