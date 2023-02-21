using Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApiControllerBase : ControllerBase
{

    protected ActionResult HandleException(Exception e)
    {
        switch (e)
        {
            case NotFoundException:
                return StatusCode(400,e.Message);
            default:
                return StatusCode(500, "Internal Server Error.");
        }
    }
}