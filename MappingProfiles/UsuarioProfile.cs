using AP3.Domain.DTOs;
using AP3.Domain.Entities;
using AutoMapper;

namespace AP3.MappingProfiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
        }
    }
}