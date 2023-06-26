using AutoMapper;
using AP3.Domain.DTOs;
using AP3.Domain.Entities;

namespace AP3.MappingProfiles
{
    public class MeuAutorProfile : Profile
    {
        public MeuAutorProfile()
        {
            CreateMap<Autor, AutorDTO>().ReverseMap();
        }
    }
}
