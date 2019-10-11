using QuestRoomCatalog.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuestRoomCatalog.Models
{
    public class RolesViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string RoleName { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}