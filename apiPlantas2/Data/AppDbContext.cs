using ApiPlantas.Data.Models;
using ApiPlantas.Data.ViewsModel;
using Microsoft.EntityFrameworkCore;

namespace ApiPlantas.Data
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
		{ 

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Planta_Reporte>()
				.HasOne(b => b.Planta)
				.WithMany(ba => ba.Planta_Reporte)
				.HasForeignKey(bi => bi.PlantaId);

			modelBuilder.Entity<Planta_Reporte>()
				.HasOne(b => b.Reporte)
				.WithMany(ba => ba.Planta_Reporte)
				.HasForeignKey(bi => bi.ReporteId);
		}
	
		public DbSet<Usuario> Usuarios{ get; set; }
		public DbSet<Reportes> Reportes{ get; set; }
		public DbSet<Planta_Reporte> Planta_Reportes { get; set; }
		public DbSet<Plantas> Plantas { get; set; }
		public DbSet<Temperatura> Temperatura { get; set; }
		public DbSet<Humedad> Humedad { get; set; }
		public DbSet<Tamaño> Tamaño { get; set; }


	}
}
