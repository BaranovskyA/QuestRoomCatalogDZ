using QuestRoomCatalog.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuestRoomCatalog.Models
{
    public class UsersViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string UserName { get; set; }

        [Required]
        public int RoleId { get; set; }

        public virtual Roles Roles { get; set; }
    }
}