using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Communication.Requests;
using MyFirstApi.Communication.Responses;

namespace MyFirstApi.Controllers;

public class UserController : MyFirstApiBaseController
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


    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateUser([FromBody] RequestUpdateUserProfileJson profileJson)
    {
        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    public IActionResult GetById(User user)
    {
        var response = new User
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email
        };

        return Ok(response);
    }

    [HttpGet]
    [ProducesResponseType(typeof (List<User>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<User>
        {
            new User { Id = 1, Email = "marcelly@gmail.com", Name = "Marcelly"},
            new User { Id = 2, Email = "daniel@gmail.com", Name = "Daniel"}
        };

        return Ok(response);
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteUser()
    {
        return NoContent();
    }

    [HttpPut("change-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword([FromBody] RequestChangePasswordJson passwordJson)
    {
        return NoContent();
    }

}
