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
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Categoria).HasMaxLength(30).IsRequired();
        }
    }
}
