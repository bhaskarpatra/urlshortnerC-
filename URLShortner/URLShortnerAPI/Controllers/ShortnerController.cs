using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace URLShortnerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShortnerController : ControllerBase
    {
        public ShortnerController()
        {
        }

        [HttpGet]
        [Route("GetUrl")]
        public IActionResult Get()
        {
            try
            {
                //Get the short Url from Database
                return Ok("Short URL");
            }
            catch (Exception)
            {
                throw;
            }
            return BadRequest();
        }




        [HttpPost]
        [Route("ShortenUrl")]
        public IActionResult ShortenUrl(string longUrl)
        {
            try
            {
                //Generate a unique url in the Database and return it
                return Ok("Hello");
            }
            catch (Exception ex)
            {
                throw;
            }
            return BadRequest();
        }
    }
}
