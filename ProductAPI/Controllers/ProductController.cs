using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok(new List<string> { "Kalem","Kitap","Silgi","Defter"});
        }
    }
}
