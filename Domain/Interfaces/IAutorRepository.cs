using System.Collections.Generic;
using AP3.Domain.Entities;

namespace AP3.Domain.Interfaces
{
   public interface IAutorRepository
    {
        Autor GetById(int autorId);
        IList<Autor> GetAll();
        void Add(Autor autor);
        void Update(Autor autor);
        void Delete(int autorId);
    }
}
