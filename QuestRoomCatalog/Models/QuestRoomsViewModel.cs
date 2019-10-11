using QuestRoomCatalog.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuestRoomCatalog.Models
{
    public class QuestRoomsViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Range(1,540)]
        public int TimeForQuest { get; set; }

        [Required]
        [Range(2,1000)]
        public int MaxGamer { get; set; }

        [Required]
        [Range(1,1000)]
        public int MinGamer { get; set; }

        [Required]
        [Range(3,99)]
        public int MinAgeGamer { get; set; }

        [Required]
        public int FearLevel { get; set; }

        public int ComplexityLevel { get; set; }

        public virtual ICollection<QuestsLogos> QuestsLogos { get; set; }

        public virtual ICollection<Rating> Rating { get; set; }
    }
}