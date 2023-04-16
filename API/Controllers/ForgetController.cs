using Entity.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    [AllowAnonymous]
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
