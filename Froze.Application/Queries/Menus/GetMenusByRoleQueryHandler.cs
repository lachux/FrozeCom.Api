using MediatR;
using Microsoft.Extensions.Logging;
using Froze.Application.DTOs.Menus;
using Froze.Application.Interfaces;
using Froze.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froze.Application.Queries.Menus
{
    public class GetMenusByRoleQueryHandler : IRequestHandler<GetMenusByRoleQuery, ApiResponse<List<MenuDto>>>
    {
        private readonly IMenuService _menuService;
        private readonly ILogger<GetMenusByRoleQueryHandler> _logger;

        public GetMenusByRoleQueryHandler(
            IMenuService menuService,
            ILogger<GetMenusByRoleQueryHandler> logger)
        {
            _menuService = menuService;
            _logger = logger;
        }

        public async Task<ApiResponse<List<MenuDto>>> Handle(GetMenusByRoleQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var menus = await _menuService.GetMenusByRoleAsync(request.RoleId);

                if (menus == null || !menus.Any())
                {
                    return ApiResponse<List<MenuDto>>.SuccessResponse(
                        new List<MenuDto>(),
                        "No menus found for this role");
                }

                return ApiResponse<List<MenuDto>>.SuccessResponse(menus, "Menus retrieved successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving menus for role {RoleId}", request.RoleId);
                return ApiResponse<List<MenuDto>>.ErrorResponse($"Error retrieving menus: {ex.Message}");
            }
        }
    }
}
