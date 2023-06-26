using AP3.Domain.DTOs;
using AP3.Domain.Entities;
using AutoMapper;

namespace AP3.MappingProfiles
{
    public class LivroProfile : Profile
    {
        public LivroProfile()
        {
            CreateMap<Livro, LivroDTO>().ReverseMap();
        }
    }
}