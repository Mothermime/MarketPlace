using System;
using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Models
{
    public class Market
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser MarketName { get; set; }
        public string Organiser { get; set; }
        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public Category Category { get; set; }

    }
}