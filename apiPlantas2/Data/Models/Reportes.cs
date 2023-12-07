using System.Collections.Generic;

namespace ApiPlantas.Data.Models
{
	public class Reportes
	{
		public int Id { get; set; }
		public bool ValvulaAbierta { get; set; }
		public string HumedadActual { get; set; }
		public string TemperaturaActual { get; set; }
		public string TamañoActual { get; set; }
		

		//porpiedades de navegacion
		public List<Planta_Reporte> Planta_Reporte { get; set; }
	}
}
