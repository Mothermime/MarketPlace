using System;
using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Models
{
    public class Market
    {
        public int Id { get; set; }

       
        public ApplicationUser Organiser { get; set; }
        [Required]
        public string OrganiserId { get; set; }

        [Required]
        [StringLength(255)]
        public string  MarketName{ get; set; }
        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

       
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }

    }
}