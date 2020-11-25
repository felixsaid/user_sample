using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [MaxLength(250)]
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
        [Required]
        [MaxLength(250)]
        public string UserPassword { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
