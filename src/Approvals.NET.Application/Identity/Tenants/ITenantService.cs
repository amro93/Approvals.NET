using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Approvals.NET.Application.Identity.Tenants.Dto;
using Approvals.NET.Domain.Wrappers;

namespace Approvals.NET.Application.Identity.Tenants
{
    public interface ITenantService
    {
        public Task<Guid> CreateAsync(TenantCreateDto dto);
        public Task<TenantDetailsDto> GetAsync(Guid id);
        public Task<TenantDetailsDto> GetByNameAsync(string name);
        public Task UpdateAsync(TenantUpdateDto dto);
        public Task<PagedResponse<List<TenantListDto>>> ListPagedAsync(PagedRequestParameter dto);
        public Task DeleteAsync(Guid id);
        Task<Guid?> NameExistsAsync(string name);
        Task ChangeName(TenantChangeNameRequest dto);
    }
}
