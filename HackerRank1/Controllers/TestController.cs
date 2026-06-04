using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryService.WebAPI.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("/protected")]
        [Authorize]
        public IActionResult Protected()
        {
            return Ok("Acceso permitido a usuario autenticado");
        }

        [HttpGet("/admin")]
        [Authorize(Roles = "admin")]
        public IActionResult Admin()
        {
            return Ok("Acceso permitido solo para admin");
        }
    }
}
