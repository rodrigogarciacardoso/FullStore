using FullStore.Application.Applications;
using FullStore.Application.Interfaces;
using FullStore.Domain.Interfaces;
using FullStore.Infra.Data.Contexto;
using FullStore.Infra.Data.Repositories;
using FullStore.Infra.Data.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace FullStore.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application
            services.AddScoped<IUsuarioApplication, UsuarioApplication>();

            // Infra - Data
            services.AddScoped<FullStoreContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
