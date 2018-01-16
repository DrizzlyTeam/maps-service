
using Microsoft.AspNetCore.Mvc;

namespace Drizzly.Service.Maps.Controllers
{
    [Route("[controller]")]
    public class ApiController : Controller
    {

        [HttpGet("/")]
        public string Get()
        {

            return "test";

        }

    }
}