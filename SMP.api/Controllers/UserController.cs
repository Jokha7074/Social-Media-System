using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SMP.Service.DTOs.Users;
using SMP.Service.IRepositories;

namespace SMP.api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    public IUserService userService;
    public UserController(IUserService userService)
    {
        this.userService = userService;
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(UserCreateDto userCreateDto)
    {
        var result = await userService.AddAsync(userCreateDto);
        return Ok(result);
    }
}
