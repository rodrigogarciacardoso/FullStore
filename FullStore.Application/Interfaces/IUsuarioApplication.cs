using FullStore.Domain.Interfaces;
using System;

namespace FullStore.Application.Interfaces
{
    public interface IUsuarioApplication : IUsuarioRepository, IDisposable
    {
    }
}
