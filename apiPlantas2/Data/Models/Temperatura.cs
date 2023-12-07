using System.Collections.Generic;

namespace ApiPlantas.Data.Models
{
	public class Temperatura
	{
		public int Id { get; set; }
		public string TemperaturaDetectada { get; set; }

		public List<Planta_Reporte> Planta_Reporte { get; set; }
	}
}
