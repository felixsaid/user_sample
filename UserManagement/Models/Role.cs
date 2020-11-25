using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        [Required]
        [MaxLength(250)]
        public string RoleName { get; set; }
        public ICollection<User> User { get; set; }
    }
}
