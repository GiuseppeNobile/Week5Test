using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Week5Test.EntityFramework;
using Week5Test.Models;

namespace Week5Test.EntityFramework.Configurations
{
    internal class CategorieConfiguration : IEntityTypeConfiguration<Categorie>
    {
        public void Configure(EntityTypeBuilder<Categorie> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Categoria).HasMaxLength(30).IsRequired();
        }
    }
}
