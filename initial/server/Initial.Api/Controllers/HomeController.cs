using Microsoft.AspNetCore.Mvc;

namespace Initial.Api.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
	    [HttpGet]
	    public ActionResult<string> Get() 
		    => "Welcome to my initial docker supported API.";
    }
}