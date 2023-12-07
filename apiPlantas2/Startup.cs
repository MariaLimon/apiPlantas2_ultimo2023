using ApiPlantas.Data.Services;
using ApiPlantas.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiPlantas.Data.Services;

namespace apiPlantas2
{
	public class Startup
	{
		public string ConnectionString { get; set; }
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
			ConnectionString = Configuration.GetConnectionString("DefaultConnectionString");
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			//configurar BDcontext con sql
			services.AddDbContext<AppDbContext>(options => options.UseSqlServer(ConnectionString));

			//configurar el servisioára que puesa ser usado
			services.AddTransient<UsuarioService>();
			services.AddTransient<PlantasServices>();
			services.AddTransient<ReporteService>();
			services.AddTransient<Planta_ReporteService>();
			services.AddTransient<TamañoService>();
			services.AddTransient<TemperaturaService>();
			services.AddTransient<HumedadServices>();


			services.AddControllers();
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "apiPlantas2", Version = "v1" });
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "apiPlantas2 v1"));
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
			AppDbInitialer.Seed(app);
		}
	}
}
