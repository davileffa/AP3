using System.Collections.Generic;
using AP3.Domain.Entities;
using AP3.Domain.Interfaces;
using AP3.Infrastructure.Data;

namespace AP3.Data.Repositories
{
     public class AutorRepository : IAutorRepository
    {
        private readonly BibliotecaContext _context;

        public AutorRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public Autor GetById(int autorId)
        {
            return _context.Autores.FirstOrDefault(a => a.Id == autorId);
        }

        public IList<Autor> GetAll()
        {
            return _context.Autores.ToList();
        }

        public void Add(Autor autor)
        {
            _context.Autores.Add(autor);
            _context.SaveChanges();
        }

        public void Update(Autor autor)
        {
            _context.Autores.Update(autor);
            _context.SaveChanges();
        }

        public void Delete(int autorId)
        {
            var autor = GetById(autorId);
            if (autor != null)
            {
                _context.Autores.Remove(autor);
                _context.SaveChanges();
            }
        }
    }
}
