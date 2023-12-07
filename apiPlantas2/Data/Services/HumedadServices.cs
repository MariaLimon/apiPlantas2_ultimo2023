using apiPlantas.Data.ViewsModel;
using ApiPlantas.Data.Models;
using ApiPlantas.Data.ViewsModel;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using System.Linq;

namespace ApiPlantas.Data.Services
{
	public class HumedadServices
	{
		private AppDbContext _context;

		public HumedadServices(AppDbContext context)
		{
			_context = context;
		}

		public void AddHumedad(HumedadVM humedad)
		{
			var _humedad = new Humedad()
			{
				HumedadDetectada = humedad.HumedadDetectada
			};
			_context.Humedad.Add(_humedad);
			_context.SaveChanges();
		}


		//listar todos los plantas
		public List<Humedad> GetAllHumedades() => _context.Humedad.ToList();
	}
}
