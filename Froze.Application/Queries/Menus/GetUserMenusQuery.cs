using MediatR;
using Froze.Application.DTOs.Menus;
using Froze.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froze.Application.Queries.Menus
{
    public class GetUserMenusQuery : IRequest<ApiResponse<List<MenuDto>>>
    {
        public int UserId { get; set; }
    }
}
