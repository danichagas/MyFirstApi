using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Entities;

namespace MyFirstApi.Controllers;
public class DeviceController : MyFirstApiBaseController
{
    [HttpGet("myRoute")]
    public IActionResult Get()
    {
        var laptop = new Laptop();
        var model = laptop.GetModel();

        return Ok(model);
    }
}
