using System.Collections.Generic;
using MediatR;
using Froze.Application.DTOs;
using Froze.Common.Models;

namespace Froze.Application.Queries
{
    public class GetUsersByTypeQuery : IRequest<ApiResponse<IEnumerable<UserDto>>>
    {
        public int PropertyId { get; set; }
        public string UserType { get; set; } = string.Empty;
    }
}