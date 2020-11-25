using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Models;
using UserManagement.Utils;

namespace UserManagement.Services
{
    public class RoleRepository : IRoleRepository
    {
        private readonly DatabaseContext _context;

        public RoleRepository(DatabaseContext context)
        {
            _context = context;
        }

        public Role CreateRole(Role roleItem)
        {
            _context.Add(roleItem);
            _context.SaveChanges();

            return roleItem;
        }

        public Role EditRole(int roleId, Role roleItem)
        {
            var role = GetRoleById(roleId);

            if (role != null)
            {
                role.RoleName = roleItem.RoleName;

                _context.Update(role);
                _context.SaveChanges();
            }

            return role;

        }

        public List<Role> GetAllRoles()
        {
            var allRoles = (from r in _context.roles
                            select new Role()
                            {
                                RoleId = r.RoleId,
                                RoleName = r.RoleName
                            }).ToList();

            return allRoles;
        }

        public Role GetRoleById(int roleId)
        {
            var allRoles = (from r in _context.roles
                            select new Role()
                            {
                                RoleId = r.RoleId,
                                RoleName = r.RoleName
                            }).FirstOrDefault(r => r.RoleId == roleId);

            return allRoles;
        }
    }
}
