using System.Collections.Generic;

namespace ApiPlantas.Data.Models
{
	public class Plantas
	{
		public int Id { get; set; }
		public string NombrePlanta { get; set; }
		public string Humedad { get; set;}
		public string Temperatura { get; set;}
		public string Tamaño { get; set;}

		//propiedades de navegacion se especifican las relaciones
		public int IdUser { get; set; }
		public Usuario usuario { get; set;}
		public List<Planta_Reporte> Planta_Reporte { get; set; }

	}
}
