using System.Collections.Generic;
using System.Linq;
using AP3.Domain.Entities;
using AP3.Domain.Interfaces;
using AP3.Data;
using AP3.Infrastructure.Data;

namespace AP3.Data.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly BibliotecaContext _context;

        public LivroRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public Livro GetById(int livroId)
        {
            return _context.Livros.FirstOrDefault(l => l.Id == livroId);
        }

        public IList<Livro> GetAll()
        {
            return _context.Livros.ToList();
        }

        public void Add(Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
        }

        public void Update(Livro livro)
        {
            _context.Livros.Update(livro);
            _context.SaveChanges();
        }

        public void Delete(int livroId)
        {
            var livro = GetById(livroId);
            if (livro != null)
            {
                _context.Livros.Remove(livro);
                _context.SaveChanges();
            }
        }

        public Task UpdateLivro(Livro livro)
        {
            throw new NotImplementedException();
        }
    }
}
