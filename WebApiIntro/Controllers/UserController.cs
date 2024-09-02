using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiIntro.Entities.Concretes;
using WebApiIntro.Services;

namespace WebApiIntro.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetUser(int id)
    {
        var user = await _userService.GetUser(id);
        return Ok(user);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAllUsers()
    {
        return Ok(await _userService.GetAllUsers());
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> AddUser([FromBody] User user)
    {
        await _userService.AddUser(user);
        return Ok("User added");
    }

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateUser([FromBody] User user)
    {
        await _userService.UpdateUser(user);
        return Ok("User guncellendi");
    }

    [HttpDelete("[action]/{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        await _userService.DeleteUser(id);
        return Ok("User Silindi");
    }
}