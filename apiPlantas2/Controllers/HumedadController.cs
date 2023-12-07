using apiPlantas.Data.ViewsModel;
using ApiPlantas.Data.Services;
using ApiPlantas.Data.ViewsModel;
using Microsoft.AspNetCore.Mvc;

namespace ApiPlantas.Controllers
{
	public class HumedadController : Controller
	{
		private HumedadServices _humedadServices;
		public HumedadController(HumedadServices humedadServices)
		{
			_humedadServices = humedadServices;
		}
		[HttpPost("add-humedad")]
		public IActionResult AddHumedad([FromBody] HumedadVM humdad)
		{
			_humedadServices.AddHumedad(humdad);
			return Ok();
		}

		[HttpGet("get-all-humedades")]
		public IActionResult GetAllHumedades()
		{
			var allhumedades = _humedadServices.GetAllHumedades();
			return Ok(allhumedades);
		}
	}
}
