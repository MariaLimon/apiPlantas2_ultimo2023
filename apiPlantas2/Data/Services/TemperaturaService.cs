using apiPlantas.Data.ViewsModel;
using ApiPlantas.Data;
using ApiPlantas.Data.Models;
using ApiPlantas.Data.ViewsModel;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using System.Linq;

namespace apiPlantas.Data.Services
{
	public class TemperaturaService
	{
		private AppDbContext _context;

		public TemperaturaService(AppDbContext context)
		{
			_context = context;
		}

		public void AddTemperatura(TemperaturaVM temperatura)
		{
			var _temperatura = new Temperatura()
			{
				TemperaturaDetectada = temperatura.TemperaturaDetectada
			};
			_context.Temperatura.Add(_temperatura);
			_context.SaveChanges();
		}

		public List<Temperatura> GetAllTemperaturas() => _context.Temperatura.ToList();
	}
}
