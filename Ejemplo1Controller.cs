using Microsoft.AspNetCore.Mvc;

namespace Proyecto
{
    [Route("api/ejemplo1")]
    public class Ejemplo1Controller : Controller
    {
        [HttpGet("prueba1")]
        public async Task<IActionResult> prueba1()
        {
            try
            {
                return Ok("Esta es una prueba");
            }
            catch {
                return BadRequest();
            }

        }

        [Produces("text/html")]
        [HttpGet("prueba2")]
        public async Task<IActionResult> prueba2()
        {
            try
            {
                return Ok("<h2><b><i>Prueba 2</i></b></h2>");
            }
            catch
            {
                return BadRequest();
            }

        }

        [Produces("text/html")]
        [HttpGet("prueba3/{val}")]
        public async Task<IActionResult> prueba3(string val)
        {
            try
            {
                return Ok("<h2><b><i>Buenas noches Sr. </i></b></h2>"+val);
            }
            catch
            {
                return BadRequest();
            }

        }

    }
}
