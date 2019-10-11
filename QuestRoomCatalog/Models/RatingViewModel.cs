using QuestRoomCatalog.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuestRoomCatalog.Models
{
    public class RatingViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int QuestRoomId { get; set; }

        public int RatingLevel { get; set; }

        public virtual QuestsRooms QuestsRooms { get; set; }
    }
}