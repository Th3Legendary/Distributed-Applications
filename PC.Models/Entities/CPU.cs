using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PC.Models.Entities
{
    public class CPU
    {
        [Key]
        public int CPUId { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string Manufacturer { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string Model { get; set; }
        public int CoreCount { get; set; }
        public float BaseClock { get; set; }
        public float BoostClock { get; set; }
        public int TDP { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string Socket { get; set; }
        public int Lithography { get; set; }
        public bool IntegrateGraphics { get; set; }
        public bool SimultaniousMultithreading { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<BuildList> BuildLists { get; set; }
    }
}
