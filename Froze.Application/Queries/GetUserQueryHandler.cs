using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Froze.Application.DTOs;
using Froze.Common.Exceptions;
using Froze.Common.Models;
using Froze.Domain.Interfaces;

namespace Froze.Application.Queries
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, ApiResponse<UserDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<GetUserQueryHandler> _logger;

        public GetUserQueryHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            ILogger<GetUserQueryHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ApiResponse<UserDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.Users.GetByIdAsync(request.UserId);

            if (user == null)
            {
                _logger.LogWarning("User not found with ID: {UserId}", request.UserId);
                return ApiResponse<UserDto>.ErrorResponse($"User with ID {request.UserId} not found");
            }

            var userDto = _mapper.Map<UserDto>(user);
            return ApiResponse<UserDto>.SuccessResponse(userDto);
        }
    }
}