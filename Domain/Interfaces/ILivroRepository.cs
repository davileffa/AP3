using System.Collections.Generic;
using AP3.Domain.Entities;

namespace AP3.Domain.Interfaces
{
    public interface ILivroRepository
    {
        Livro GetById(int livroId);
        IList<Livro> GetAll();
        void Add(Livro livro);
        void Update(Livro livro);
        void Delete(int livroId);
        Task UpdateLivro(Livro livro);
    }
}
