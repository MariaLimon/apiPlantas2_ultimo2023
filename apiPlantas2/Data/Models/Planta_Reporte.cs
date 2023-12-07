namespace ApiPlantas.Data.Models
{
	public class Planta_Reporte
	{
		public int Id { get; set; }
		public Plantas Planta { get; set; }
		public int PlantaId { get; set; }
		public Reportes Reporte { get; set; }
		public int ReporteId { get; set; }
		public Temperatura temperatura { get; set; }
		public int TemperaturaId { get; set; }
		public Humedad humedad { get; set; }
		public int HumedadId { get; set; }
		public Tamaño tamaño { get; set; }
		public int TamañoId { get; set; }

	}
}
