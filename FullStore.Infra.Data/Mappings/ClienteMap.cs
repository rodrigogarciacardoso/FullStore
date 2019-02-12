using FullStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullStore.Infra.Data.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(100);
            builder.Property(x => x.Sobrenome).HasMaxLength(100);
            builder.Property(x => x.Telefone).HasMaxLength(15);
            builder.Property(x => x.DataNascimento);
        }
    }
}
