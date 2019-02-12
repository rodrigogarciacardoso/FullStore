using FullStore.Application.Interfaces;
using FullStore.Domain.Entities;
using System;
using System.Linq;

namespace FullStore.Application.Applications
{
    public class UsuarioApplication : IUsuarioApplication
    {
        public void Add(Usuario obj)
        {
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IQueryable<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}
