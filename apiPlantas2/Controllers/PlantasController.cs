using ApiPlantas.Data.Services;
using ApiPlantas.Data.ViewsModel;
using Microsoft.AspNetCore.Mvc;

namespace ApiPlantas.Controllers
{
	public class PlantasController : Controller
	{
		private PlantasServices _plantasServices;
		public PlantasController(PlantasServices plantasServices)
		{
			_plantasServices = plantasServices;
		}
		[HttpPost("add-planta")]
		public IActionResult AddPlantaWhitUser([FromBody] PlantasVM planta)
		{
			_plantasServices.AddPlantaWhitUser(planta);
			return Ok();
		}

		[HttpGet("get-plantas-with-user-by-id/{id}")]
		public IActionResult GetReportesByIdPlanta(int id)
		{
			var response = _plantasServices.GetReportesByIdPlanta(id);
			return Ok(response);
		}

		[HttpGet("get-all-plantas")]
		public IActionResult GetAllPlantas()
		{
			var allplantas = _plantasServices.GetAllPlantas();
			return Ok(allplantas);
		}
	}
}
