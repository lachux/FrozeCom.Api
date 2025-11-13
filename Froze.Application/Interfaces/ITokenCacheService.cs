using System.Threading.Tasks;
using Froze.Common.Models;

namespace Froze.Application.Interfaces
{
    public interface ITokenCacheService
    {
        Task<TokenResponse?> GetTokenAsync(string clientId);
        Task SetTokenAsync(string clientId, TokenResponse token);
        Task RemoveTokenAsync(string clientId);
        Task<bool> IsTokenExpiredAsync(string clientId);
    }
}