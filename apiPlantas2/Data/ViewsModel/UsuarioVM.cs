using System.Collections.Generic;

namespace ApiPlantas.Data.ViewsModel
{
	public class UsuarioVM
	{
		public string NombreUsuario { get; set; }
		public string Correo { get; set; }
		public int NumTelefono { get; set; }
	}

	public class UsusarioPlantaReporte
	{
		public string Nombre { get; set; }
		public List<PlantaReporteVM> PlantaReporte { get; set; }
	}

	public class PlantaReporteVM
	{
		public string NombrePlanta { get; set; }
		public List<int> idReportes { get; set; }
	}
}
