using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Models;

namespace UserManagement.Services
{
    public interface IRoleRepository
    {
        public List<Role> GetAllRoles();
        public Role GetRoleById(int roleId);
        public Role CreateRole(Role roleItem);
        public Role EditRole(int roleId, Role roleItem);
    }
}
