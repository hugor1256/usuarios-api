using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.DTOs;
using UsuariosApi.Models;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {
        
        private CadastroService _cadastroService;

        public UsuarioController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }
        
        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario(CreateUsuarioDto dto)
        {
            await _cadastroService.Cadastra(dto);

            return Ok("Usuario Cadastrado!");
        }
    }
}