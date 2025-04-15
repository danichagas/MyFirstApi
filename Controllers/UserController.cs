using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [Route("{id}/email/{email}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult UserName(int id, string email)
    {
        var response = new User
        {
            Id = id,
            Name = "Daniel",
            Email = email
        };

        return Ok(response);
    }
}