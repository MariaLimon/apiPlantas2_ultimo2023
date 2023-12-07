using System.Collections.Generic;

namespace ApiPlantas.Data.Models
{
	public class Humedad
	{
		public int Id { get; set; }
		public string HumedadDetectada { get; set; }

		public List<Planta_Reporte> Planta_Reporte { get; set; }
	}
}