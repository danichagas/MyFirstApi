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
    public IActionResult CreateUser([FromBody] RequestRegisterUserJson request)
    {
        var response = new ResponseRegisterUserJson
        {
            Id = 1,
            Name = request.Name
        };
        return Created(string.Empty, response);
    }

    [HttpGet]
    [Route("{id}/email/{email}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetUser(int id, string email)
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