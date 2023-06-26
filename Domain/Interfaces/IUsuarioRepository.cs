using System.Collections.Generic;
using AP3.Domain.Entities;

namespace AP3.Domain.Interfaces
{
   public interface IUsuarioRepository
    {
        Usuario GetById(int usuarioId);
        IList<Usuario> GetAll();
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int usuarioId);
        void Delete(Usuario usuario);
    }
}
