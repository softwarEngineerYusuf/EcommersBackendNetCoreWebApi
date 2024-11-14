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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Primary key ayarı
            builder.HasKey(c => c.Id);

            // Name alanı, zorunlu ve 100 karakterden uzun olamaz
            builder.Property(c => c.Name)
                .IsRequired()  // Zorunlu hale getirildi
                .HasMaxLength(100);  // Maksimum uzunluk 100 karakter

            // Description alanı, 500 karakterden uzun olamaz
            builder.Property(c => c.Description)
                .HasMaxLength(500);

            // ImageUrl alanı isteğe bağlıdır, ancak var olması gerektiği durumlar için
            builder.Property(c => c.ImageUrl)
                .HasMaxLength(200);
        }
    }
}
