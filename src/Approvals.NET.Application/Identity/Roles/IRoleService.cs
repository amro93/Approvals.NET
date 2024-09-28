using Approvals.NET.Application.Identity.Roles.Dto;
using Approvals.NET.Domain.Wrappers;
using System;
using System.Threading.Tasks;

namespace Approvals.NET.Application.Identity.Roles
{
    public interface IRoleService
    {
        Task<RoleListDto> GetAllAsync();
        Task<PagedResponse<RoleListDto>> GetPagedAsync(PagedRequestParameter dto);
        Task<RoleDetailsDto> GetAsync(Guid id);
        Task<Guid> CreateAsync(RoleCreateDto dto);
        Task<Guid> UpdateAsync(RoleUpdateDto dto);
        Task DeleteAsync(Guid id);
    }
}
