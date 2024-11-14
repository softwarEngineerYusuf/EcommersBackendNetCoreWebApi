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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Primary key ayarı
            builder.HasKey(p => p.Id);

            // Name alanı, zorunlu ve 100 karakterden uzun olamaz
            builder.Property(p => p.Name)
                .IsRequired()  // Zorunlu hale getirildi
                .HasMaxLength(100);  // Maksimum uzunluk 100 karakter

            // Price alanı, 18 basamaktan ve 2 desimal noktadan oluşur (decimal)
            builder.Property(p => p.Price)
                .HasPrecision(18, 2);

            // Discount alanı da aynı şekilde decimal türünde ve 2 desimal noktası olacak
            builder.Property(p => p.Discount)
                .HasPrecision(18, 2);

            // IsActive, varsayılan olarak true olacak
            builder.Property(p => p.IsActive)
                .HasDefaultValue(true);

            // İlişkiler: Bir Product'un bir Brand ve bir Category'e bağlı olduğu belirtiliyor
            builder.HasOne(p => p.Brand)
                .WithMany(b => b.Products)  // Bir Brand birçok Product'a sahip olabilir
                .HasForeignKey(p => p.BrandId);  // Product'taki BrandId ile ilişkileniyor

            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)  // Bir Category birçok Product'a sahip olabilir
                .HasForeignKey(p => p.CategoryId);  // Product'taki CategoryId ile ilişkileniyor

            // Bir Product'ın birden fazla ProductImage'ı olabilir
            builder.HasMany(p => p.ProductImages)
                .WithOne(pi => pi.Product)
                .HasForeignKey(pi => pi.ProductId);  // ProductImage'taki ProductId ile ilişkileniyor
        }
    }
}
