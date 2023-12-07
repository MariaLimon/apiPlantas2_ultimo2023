using ApiPlantas.Data;
using ApiPlantas.Data.Models;
using ApiPlantas.Data.Services;
using ApiPlantas.Data.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace apiPlantas.Data.Services
{
	public class Planta_ReporteService
	{
		private AppDbContext _context;
		public Planta_ReporteService(AppDbContext context)
		{
			_context = context;
		}

		public void AddPlanta_Resporte(Planta_reporteVM planta_Reporte)
		{
			var _planta_reporte = new Planta_Reporte()
			{
				PlantaId = planta_Reporte.PlantaId,
				ReporteId = planta_Reporte.ReporteId,
				HumedadId = planta_Reporte.HumedadId,
				TemperaturaId = planta_Reporte.TemperaturaId,
				TamañoId = planta_Reporte.TamañoId
			};
			_context.Planta_Reportes.Add(_planta_reporte);
			_context.SaveChanges();
		}


		public List<Planta_Reporte> GetAllP_R() => _context.Planta_Reportes.ToList();
	}
}
