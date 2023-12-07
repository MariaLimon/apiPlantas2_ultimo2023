using ApiPlantas.Data.Models;
using ApiPlantas.Data.ViewsModel;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using System.Linq;

namespace ApiPlantas.Data.Services
{
	public class PlantasServices
	{
		private AppDbContext _context;

		public PlantasServices(AppDbContext context)
		{
			_context = context;
		}

		public void AddPlantaWhitUser(PlantasVM planta)
		{
			var _planta = new Plantas()
			{
				NombrePlanta = planta.NombrePlanta,
				Humedad = planta.Humedad,
				Temperatura = planta.Temperatura,
				Tamaño = planta.Tamaño,
				IdUser = planta.IdUser
			};
			_context.Plantas.Add(_planta);
			_context.SaveChanges();
		}


		public PlantasWithReportesVM GetReportesByIdPlanta(int plantaId)
		{
			var _plantasWithUsuario = _context.Plantas.Where(n => n.Id == plantaId).Select(planta => new PlantasWithReportesVM()
			{
				NombrePlanta = planta.NombrePlanta,
				Humedad = planta.Humedad,
				Temperatura = planta.Temperatura,
				Tamaño = planta.Tamaño,
				ReporteId = planta.Planta_Reporte.Select(n => n.ReporteId).ToList(),
			}).FirstOrDefault();
			return _plantasWithUsuario;

		}


		//listar todos los plantas
		public List<Plantas> GetAllPlantas() => _context.Plantas.ToList();
	}
}
