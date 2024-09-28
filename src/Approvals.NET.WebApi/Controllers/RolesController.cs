using Approvals.NET.Application.Identity.Roles.Dto;
using Approvals.NET.Domain.Entities.Identity;
using Approvals.NET.Domain.Wrappers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Approvals.NET.WebApi.Controllers
{
    public class RolesController : BaseApiController
    {
        private readonly RoleManager<ApplicationRole> _roleManager;

        public RolesController(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [HttpGet]
        public async Task<PagedResponse<List<RoleListDto>>> GetAsync([FromQuery] PagedRequestParameter dto)
        {
            return new PagedResponse<List<RoleListDto>>(new List<RoleListDto>(), dto.PageNumber, dto.PageSize);
        }

        [HttpGet]
        public async Task<List<RoleListDto>> GetAllAsync()
        {
            return await _roleManager.Roles.Select(t => new RoleListDto
            {
                Id = t.Id,
                IsDefault = t.IsDefault,
                IsPublic = t.IsPublic,
                Name = t.Name,
                TenantId = t.TenantId
            }).ToListAsync();
        }

        [HttpGet]
        public async Task<RoleDetailsDto?> GetDetailsAsync([FromRoute][Required] Guid id)
        {
            return await _roleManager.Roles.Select(t => new RoleDetailsDto
            {
                Id = t.Id,
                IsDefault = t.IsDefault,
                IsPublic = t.IsPublic,
                Name = t.Name,
                TenantId = t.TenantId
            }).FirstOrDefaultAsync();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] RoleCreateDto dto)
        {
            return Ok(new { Id = Guid.NewGuid() });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] RoleUpdateDto dto)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] Guid id)
        {
            return Ok();
        }
    }
}
