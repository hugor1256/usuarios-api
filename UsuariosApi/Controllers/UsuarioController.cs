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
        
        private UsuarioService _usuarioService;
        private UsuarioService _loginService;

        public UsuarioController(UsuarioService usuarioService, UsuarioService loginService)
        {
            _usuarioService = usuarioService;
            _loginService = loginService;
        }
        
        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastrarUsuario(CreateUsuarioDto dto)
        {
            await _usuarioService.Cadastra(dto);

            return Ok("Usuario Cadastrado!");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUsuarioDto dto)
        {
           var token = await _loginService.Login(dto);

            return Ok(token);
        }
    }
}