using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froze.Application.Interfaces
{
    public interface IAuditService
    {
        Task LogAsync(string tableName, int recordId, string action, object? oldValues, object? newValues);
    }
}
