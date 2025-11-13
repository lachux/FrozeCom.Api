using Froze.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froze.Domain.Interfaces
{
    public interface IMenuRepository : IRepository<Menu>
    {
        Task<IEnumerable<Menu>> GetMenusByUserIdAsync(int userId);
        Task<IEnumerable<Menu>> GetMenusByRoleIdsAsync(List<int> roleIds);
    }
}
