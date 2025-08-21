using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok(new List<string> { "Hilmi Celayir","Cengiz Han","Eren Özdemir"});
        }
    }
}
