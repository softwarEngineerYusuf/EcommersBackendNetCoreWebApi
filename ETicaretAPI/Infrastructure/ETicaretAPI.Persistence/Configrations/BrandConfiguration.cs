using ETicaretAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Configrations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            // Primary key ayarı
            builder.HasKey(b => b.Id);

            // Name alanı, zorunlu ve 100 karakterden uzun olamaz
            builder.Property(b => b.Name)
                .IsRequired()  // Zorunlu hale getirildi
                .HasMaxLength(100);  // Maksimum uzunluk 100 karakter

            // Description alanı, 500 karakterden uzun olamaz
            builder.Property(b => b.Description)
                .HasMaxLength(500);
        }
    }
}
