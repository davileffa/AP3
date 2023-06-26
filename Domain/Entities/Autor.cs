using System;
using AutoMapper;

namespace AP3.Domain.Entities
{
     public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nacionalidade { get; set; }
    }
}