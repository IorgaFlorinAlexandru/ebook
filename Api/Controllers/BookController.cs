using Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class BookController : ApiControllerBase {

    [HttpGet]
    public ActionResult<string> Get(){
        return "Hello World";
    }

    [HttpPost]
    public ActionResult Post(){
        throw new NotImplementedException();
    }

    [HttpPut]
    public ActionResult Put(){
        throw new NotImplementedException();
    }

    [HttpDelete]
    public ActionResult Delete(){
        throw new NotImplementedException();
    }

}