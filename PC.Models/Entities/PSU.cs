using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PC.Models.Entities
{
    public class PSU 
    {
        [Key]
        public int PSUId { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string Manufacturer { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string Model { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string FormFactor { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string Efficiency { get; set; }
        public int Wattage { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string Modular { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<BuildList> BuildLists { get; set; }
    }
}
