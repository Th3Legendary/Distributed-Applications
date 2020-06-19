using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PC.Models.Entities
{
    public class GPU 
    {
        [Key]
        public int GPUId { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string Manufacturer { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string Model { get; set; }
        public int MemoryCapacity { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string MemoryType { get; set; }
        public int MemoryClock { get; set; }
        public float BaseClock { get; set; }
        public float BoostClock { get; set; }
        public int TDP { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string Chipset { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<BuildList> BuildLists { get; set; }
    }
}
