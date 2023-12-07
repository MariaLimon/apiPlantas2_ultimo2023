using apiPlantas.Data.ViewsModel;
using ApiPlantas.Data;
using ApiPlantas.Data.Models;
using ApiPlantas.Data.ViewsModel;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using System.Linq;

namespace apiPlantas.Data.Services
{
	public class ReporteService
	{
		private AppDbContext _context;

		public ReporteService(AppDbContext context)
		{
			_context = context;
		}

		public void AddReporte(ReporteVM reporte)
		{
			var _reporte = new Reportes()
			{
				ValvulaAbierta = reporte.ValvulaAbierta,
				HumedadActual = reporte.HumedadActual,
				TemperaturaActual = reporte.TemperaturaActual,
				TamañoActual = reporte.TamañoActual,
				
				
			};
			_context.Reportes.Add(_reporte);
			_context.SaveChanges();
		}

		public List<Reportes> GetAllReportes() => _context.Reportes.ToList();
	}
}
