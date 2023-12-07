using apiPlantas.Data.Services;
using ApiPlantas.Data.ViewsModel;
using Microsoft.AspNetCore.Mvc;

namespace ApiPlantas.Controllers
{
	public class Planta_ReporteController : Controller
	{
		private Planta_ReporteService _planta_ReporteServices;
		public Planta_ReporteController(Planta_ReporteService planta_ReporteServices)
		{
			_planta_ReporteServices = planta_ReporteServices;
		}
		[HttpPost("add-planta_reporte")]
		public IActionResult AddPlanta_Resporte([FromBody] Planta_reporteVM planta_reporte)
		{
			_planta_ReporteServices.AddPlanta_Resporte(planta_reporte);
			return Ok();
		}

		//[HttpGet("get-plantas-with-user-by-id/{id}")]
		//public IActionResult GetAuthorWithBooks(int id)
		//{
		//	var response = _plantasServices.GetAuthorWithBooks(id);
		//	return Ok(response);
		//}

		[HttpGet("get-all-PR")]
		public IActionResult GetAllP_R()
		{
			var allpr = _planta_ReporteServices.GetAllP_R();
			return Ok(allpr);
		}
	}
}
