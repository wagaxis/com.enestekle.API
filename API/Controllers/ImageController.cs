using Business.Concerete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class ImageController : ControllerBase
    { 

        private readonly ImageBusiness _imageBusiness = new ImageBusiness();

        // POST api/<ImageController>
        [HttpPost]
        public async Task<IActionResult> Resize(IFormFile file)
        {
            var memory =  _imageBusiness.ResizeImage(file.OpenReadStream());
            return File(memory.ToArray(), file.ContentType);
        }
    }
}
