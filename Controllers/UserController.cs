using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Communication.Requests;
using MyFirstApi.Communication.Responses;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
    public IActionResult CreateUser([FromBody] RequestRegisterUserJson userJson)
    {
        var response = new ResponseRegisterUserJson
        {
            Id = 1,
            Name = userJson.Name
        };
        return Created(string.Empty, response);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    public IActionResult GetUser(User user)
    {
        var response = new User
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email
        };

        return Ok(response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateUser([FromBody] RequestUpdateUserProfileJson profileJson)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteUser()
    {
        return NoContent();
    }
}
