using MediatR;
using Froze.Application.DTOs.Auth;
using Froze.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froze.Application.Commands.Auth
{
    public class LoginUserCommand : IRequest<ApiResponse<LoginResponseDto>>
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
