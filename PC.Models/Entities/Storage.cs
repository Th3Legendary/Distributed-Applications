using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PC.Models.Entities
{
    public class Storage
    {
        [Key]
        public int StorageId { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string Manufacturer { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string Model { get; set; }
        public int Capacity { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string Type { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string Interface { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<BuildList> BuildLists { get; set; }
    }
}
