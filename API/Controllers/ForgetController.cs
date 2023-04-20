using com.enestekle.Entity.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace com.enestekle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ForgetController : ControllerBase
    {
        private readonly ILogger<ForgetController> _logger;

        public ForgetController(ILogger<ForgetController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get_Word()
        {
            try
            {
                Random rand = new Random();
                RandomModel deneme = new RandomModel()
                {
                    IdWagaxis = Guid.NewGuid(),
                    Wagaxis = rand.NextDouble() * 252525
                };
                return new JsonResult(deneme);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                _logger.LogError(ex, "Hata oluştu.");
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
