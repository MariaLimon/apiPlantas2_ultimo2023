using apiPlantas.Data.Services;
using apiPlantas.Data.ViewsModel;
using ApiPlantas.Data.Services;
using ApiPlantas.Data.ViewsModel;
using Microsoft.AspNetCore.Mvc;

namespace ApiPlantas.Controllers
{
	public class TamañaoController : Controller
	{
		private TamañoService _tamañoServices;
		public TamañaoController(TamañoService tamañoServices)
		{
			_tamañoServices = tamañoServices;
		}
		[HttpPost("add-tamaño")]
		public IActionResult AddTamaño([FromBody] TamañoVM tamaño)
		{
			_tamañoServices.AddTamaño(tamaño);
			return Ok();
		}

		[HttpGet("get-all-tamaño")]
		public IActionResult GetAllTamaños()
		{
			var alltamaños = _tamañoServices.GetAllTamaños();
			return Ok(alltamaños);
		}
	}
}
