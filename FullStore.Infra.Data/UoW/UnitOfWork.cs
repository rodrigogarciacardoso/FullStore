using FullStore.Domain.Interfaces;
using FullStore.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStore.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FullStoreContext _context;

        public UnitOfWork(FullStoreContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
