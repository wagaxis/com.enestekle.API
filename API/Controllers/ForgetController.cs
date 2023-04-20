using com.enestekle.Entity.Domain;
using Microsoft.AspNetCore.Mvc;

namespace com.enestekle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForgetController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get_Word()
        {
            Random rand = new Random();
            RandomModel deneme = new RandomModel()
            {
                IdWagaxis = Guid.NewGuid(),
                Wagaxis = rand.NextDouble() * 252525
            };
            return new JsonResult(deneme);
        }
    }
}
