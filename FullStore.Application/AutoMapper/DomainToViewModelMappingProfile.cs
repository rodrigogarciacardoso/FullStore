using AutoMapper;
using FullStore.Application.ViewModels;
using FullStore.Domain.Entities;

namespace FullStore.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, UsuarioViewModel>();
        }
    }
}
