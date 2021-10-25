
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ResponseService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponseController : ControllerBase
    {
        [Route("{id}")]
        public ActionResult GiveAResponse(int id)
        {
            Random rnd = new Random();
            int rndInteger = rnd.Next(1, 101);
            if(rndInteger >= id )
            {
                Console.WriteLine($"-> Return 500");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            else
            {
                Console.WriteLine($"-> Return 200");
                return Ok();
            }
        }
    }
}

