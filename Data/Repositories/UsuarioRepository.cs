using System.Collections.Generic;
using System.Linq;
using AP3.Domain.Entities;
using AP3.Domain.Interfaces;
using AP3.Data;
using AP3.Infrastructure.Data;

namespace AP3.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BibliotecaContext _context;

        public UsuarioRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public Usuario GetById(int usuarioId)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Id == usuarioId);
        }

        public IList<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        public void Add(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void Delete(int usuarioId)
        {
            var usuario = GetById(usuarioId);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }

        public void Delete(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}