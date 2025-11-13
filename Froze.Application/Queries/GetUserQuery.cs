using MediatR;
using Froze.Application.DTOs;
using Froze.Common.Models;

namespace Froze.Application.Queries
{
    public class GetUserQuery : IRequest<ApiResponse<UserDto>>
    {
        public int UserId { get; set; }
    }
}