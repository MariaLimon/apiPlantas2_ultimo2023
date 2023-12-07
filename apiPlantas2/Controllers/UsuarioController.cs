using ApiPlantas.Data.Services;
using ApiPlantas.Data.ViewsModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPlantas.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsuarioController : ControllerBase
	{
		public UsuarioService _usuarioService;

		public UsuarioController(UsuarioService usuarioService)
		{
			_usuarioService = usuarioService;
		}

		[HttpPost("add-users")]
		public IActionResult AddUsuario([FromBody]UsuarioVM usuario)
		{
			_usuarioService.AddUsuarios(usuario);
			return Ok();
		}

		[HttpGet("get-all-users")]
		public IActionResult GetAllUsuarios()
		{
			var allusers = _usuarioService.GetAllUsuarios();
			return Ok(allusers);
		}

		[HttpGet("get-users-by-id/{id}")]
		public IActionResult GetUsuariosById(int id)
		{
			var user = _usuarioService.GetUsuariosById(id);
			return Ok(user);
		}

		[HttpPut("update-user-by-id/{id}")]
		public IActionResult UpdateUserByID(int id, [FromBody] UsuarioVM user)
		{
			var updateuser = _usuarioService.UpdateUserByID(id, user);
			return Ok(updateuser);
		}

		[HttpDelete("delete-user-by-id/{id}")]
		public IActionResult DeleteUserById(int id)
		{
			_usuarioService.DeleteUserById(id);
			return Ok();
		}
	}
}
