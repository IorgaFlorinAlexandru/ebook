using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApiControllerBase : ControllerBase {

    protected ActionResult HandleException(Exception e){
        throw new NotImplementedException();
    }
}