using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Week5Test.EntityFramework;
using Week5Test.Models;

namespace Week5Test.EntityFramework.Configurations
{
    internal class SpeseConfiguration : IEntityTypeConfiguration<Spese>
    {
        public void Configure(EntityTypeBuilder<Spese> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Data).IsRequired();
            builder.Property(s => s.Descrizione).HasMaxLength(500).IsRequired();
            builder.Property(s => s.Utente).HasMaxLength(100).IsRequired();
            builder.Property(s => s.Importo).IsRequired();
            builder.Property(s => s.Approvato).IsRequired();

            builder.HasOne(s => s.Categoria).WithMany(c => c.ListaSpese);
        }
    }
}
