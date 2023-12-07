using apiPlantas.Data.Services;
using apiPlantas.Data.ViewsModel;
using ApiPlantas.Data.Services;
using ApiPlantas.Data.ViewsModel;
using Microsoft.AspNetCore.Mvc;

namespace apiPlantas2.Controllers
{
	public class ReporteController : Controller
	{
		public ReporteService _reporteService;

		public ReporteController(ReporteService reporteService)
		{
			_reporteService = reporteService;
		}

		[HttpPost("add-reporte")]
		public IActionResult AddReporte([FromBody] ReporteVM reporte)
		{
			_reporteService.AddReporte(reporte);
			return Ok();
		}

		[HttpGet("get-all-reportes")]
		public IActionResult GetAllReportes()
		{
			var allreportes = _reporteService.GetAllReportes();
			return Ok(allreportes);
		}
	}
}
