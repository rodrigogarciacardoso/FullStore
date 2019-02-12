using AutoMapper;
using FullStore.Application.ViewModels;
using FullStore.Domain.Entities;

namespace FullStore.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UsuarioViewModel, Usuario>();
        }
    }
}
