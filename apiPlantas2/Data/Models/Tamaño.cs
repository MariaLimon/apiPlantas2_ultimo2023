using System.Collections.Generic;

namespace ApiPlantas.Data.Models
{
	public class Tamaño
	{
		public int Id { get; set; }
		public string TamañoDetectada { get; set; }

		public List<Planta_Reporte> Planta_Reporte { get; set; }
	}
}