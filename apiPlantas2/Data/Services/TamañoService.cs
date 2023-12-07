using apiPlantas.Data.ViewsModel;
using ApiPlantas.Data;
using ApiPlantas.Data.Models;
using ApiPlantas.Data.ViewsModel;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using System.Linq;

namespace ApiPlantas.Data.Services
{
	public class TamañoService
	{
		private AppDbContext _context;

		public TamañoService(AppDbContext context)
		{
			_context = context;
		}

		public void AddTamaño(TamañoVM tamaño)
		{
			var _tamaño = new Tamaño()
			{
				TamañoDetectada = tamaño.TamañoDetectada
			};
			_context.Tamaño.Add(_tamaño);
			_context.SaveChanges();
		}

		public List<Tamaño> GetAllTamaños() => _context.Tamaño.ToList();
	}
}
