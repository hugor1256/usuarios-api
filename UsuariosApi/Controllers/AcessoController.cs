using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UsuariosApi.Controllers
{
    [Controller]
    [Route("[Controller]")]
    public class AcessoController : ControllerBase
    {
        [HttpGet]
        [Authorize(policy: "idadeMinima")]
        public IActionResult Get()
        {
            
            
            return Ok("Acesso permitido");
        }
    }
}

