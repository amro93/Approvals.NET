using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Approvals.NET.Application.Identity.Users.Dto;
using Approvals.NET.Domain.Wrappers;
using Approvals.NET.Application.Identity.UserRoles.Dto;

namespace Approvals.NET.WebApi.Controllers
{
    public class UsersController : BaseApiController
    {
        public UsersController()
        {

        }

        [HttpGet]
        public async Task<PagedResponse<List<UserListDto>>> GetAsync([FromQuery] PagedRequestParameter dto)
        {
            return new PagedResponse<List<UserListDto>>(new List<UserListDto>(), dto.PageNumber, dto.PageSize);
        }

        [HttpGet("all")]
        public async Task<List<UserListDto>> GetAllAsync()
        {
            return new List<UserListDto>();
        }

        [HttpGet("{id}")]
        public async Task<UserDetailsDto> GetDetailsAsync([FromRoute][Required] Guid id)
        {
            return new UserDetailsDto();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] UserCreateDto dto)
        {
            return Ok(new { Id = Guid.NewGuid() });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] UserUpdateDto dto)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] Guid id)
        {
            return Ok();
        }

        [HttpGet("{username}")]
        public async Task<UserDetailsDto> FindByUserNameAsync([FromRoute][Required] string username)
        {
            return new UserDetailsDto();
        }

        [HttpGet("{email}")]
        public async Task<UserDetailsDto> FindByEmailAsync([FromRoute][Required] string email)
        {
            return new UserDetailsDto();
        }

        [HttpGet("{id}/roles")]
        public async Task<List<UserRoleListDto>> GetUserRolesAsync([FromRoute] Guid id)
        {
            return new List<UserRoleListDto>();
        }

        [HttpPut("{id}/roles")]
        public async Task<List<UserRoleListDto>> UpdateUserRolesAsync([FromRoute] Guid id, [FromBody] UserRolesUpdateDto dto)
        {
            return new List<UserRoleListDto>();
        }
    }
}
