﻿using System.Collections.Generic;

namespace ApiPlantas.Data.Models
{
	public class Usuario
	{
		public int Id { get; set; }
		public string NombreUsuario { get; set; }
		public string Correo { get; set;}
		public int NumTelefono { get; set;}

		public List<Plantas> Plantas { get; set; }
	}
}
