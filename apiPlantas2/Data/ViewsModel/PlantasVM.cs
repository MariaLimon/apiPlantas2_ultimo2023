using ApiPlantas.Data.Models;
using System.Collections.Generic;

namespace ApiPlantas.Data.ViewsModel
{
	public class PlantasVM
	{
		public string NombrePlanta { get; set; }
		public string Humedad { get; set; }
		public string Temperatura { get; set; }
		public string Tamaño { get; set; }
		public int IdUser { get; set; }
		public List<int> ReporteId { get; set; }

	}
	public class PlantasWithReportesVM
	{
		public string NombrePlanta { get; set; }
		public string Humedad { get; set; }
		public string Temperatura { get; set; }
		public string Tamaño { get; set; }
		public string NombreUsuario { get; set; }
		public List<int> ReporteId { get; set; }
	}


}
