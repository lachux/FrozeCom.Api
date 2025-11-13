using MediatR;
using Froze.Application.DTOs;
using Froze.Common.Models;

namespace Froze.Application.Commands
{
    public class RegisterUserCommand : IRequest<ApiResponse<UserDto>>
    {
        public RegisterUserDto RegisterUserDto { get; set; } = null!;
    }
}