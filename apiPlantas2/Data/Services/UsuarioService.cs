using ApiPlantas.Data.Models;
using ApiPlantas.Data.ViewsModel;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using System.Linq;

namespace ApiPlantas.Data.Services
{
	public class UsuarioService
	{
		//agregar usuarios a la bd
		private AppDbContext _context;
		public UsuarioService(AppDbContext context)
		{
			_context = context;
		}

		public void AddUsuarios(UsuarioVM usuario)
		{
			var _usuario = new Usuario()
			{
				NombreUsuario = usuario.NombreUsuario,
				Correo = usuario.Correo,
				NumTelefono = usuario.NumTelefono,
			};
			_context.Usuarios.Add(_usuario);
			_context.SaveChanges();
		}

		//listar todos los usuarios
		public List<Usuario> GetAllUsuarios() => _context.Usuarios.ToList();

		//mostrar un usuario por id
		public Usuario GetUsuariosById(int usuarioid) => _context.Usuarios.FirstOrDefault(n => n.Id == usuarioid);


		//editar un usuario de la base de datos
		public Usuario UpdateUserByID(int userid, UsuarioVM user)
		{
			var _usuario = _context.Usuarios.FirstOrDefault(n => n.Id == userid);
			if (_usuario != null)
			{
				_usuario.NombreUsuario = user.NombreUsuario;
				_usuario.Correo = user.Correo;
				_usuario.NumTelefono = user.NumTelefono;
				_context.SaveChanges();
			}
			return _usuario;
		}

		//eliminar un ususario de la bd por id
		public void DeleteUserById(int userid)
		{
			var _user = _context.Usuarios.FirstOrDefault(n => n.Id == userid);
			if (_user != null)
			{
				_context.Usuarios.Remove(_user);
				_context.SaveChanges();
			}
		}
	}
}
