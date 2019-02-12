using FullStore.Domain.Entities;
using FullStore.Domain.Interfaces;
using FullStore.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStore.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(FullStoreContext context) : base(context)
        {
        }
    }
}
