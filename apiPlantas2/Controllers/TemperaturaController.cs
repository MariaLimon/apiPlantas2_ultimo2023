using apiPlantas.Data.Services;
using apiPlantas.Data.ViewsModel;
using ApiPlantas.Data.Services;
using ApiPlantas.Data.ViewsModel;
using Microsoft.AspNetCore.Mvc;

namespace ApiPlantas.Controllers
{
	public class TemperaturaController : Controller
	{
		private TemperaturaService _temperaturaServices;
		public TemperaturaController(TemperaturaService temperaturaServices)
		{
			_temperaturaServices = temperaturaServices;
		}
		[HttpPost("add-tempratura")]
		public IActionResult AddTemperatura([FromBody] TemperaturaVM planta)
		{
			_temperaturaServices.AddTemperatura(planta);
			return Ok();
		}


		[HttpGet("get-all-temperaturas")]
		public IActionResult GetAllTemperaturas()
		{
			var allplantas = _temperaturaServices.GetAllTemperaturas();
			return Ok(allplantas);
		}
	}
}
