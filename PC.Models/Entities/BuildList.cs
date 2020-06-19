using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PC.Models.Entities
{
    public class BuildList
    {
        [Key]
        public int BuildId { get; set; }
        public CPU CPU { get; set; }
        public int CPUId { get; set; }
        public Motherboard Motherboard { get; set; }
        public int MotherboardId { get; set; }
        public Memory Memory { get; set; }
        public int MemoryId { get; set; }
        public Storage Storage { get; set; }
        public int StorageId { get; set; }
        public GPU GPU { get; set; }
        public int GPUId { get; set; }
        public PSU PSU { get; set; }
        public int PSUId { get; set; }
        public Case Case { get; set; }
        public int CaseId { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Типът трябва да бъде между {2} и {1} символа.", MinimumLength = 3)]
        public string Name { get; set; }

    }
}
