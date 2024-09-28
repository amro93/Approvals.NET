using Approvals.NET.Application.Identity.UserRoles.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approvals.NET.Application.Identity.UserRoles
{
    public interface UserRoleService
    {
        Task<List<UserRoleListDto>> GetUserRolesAsync(Guid UserId);
        Task<List<UserRoleListDto>> UpdateUserRolesAsync(Guid UserId, UserRolesUpdateDto dto);
    }
}
