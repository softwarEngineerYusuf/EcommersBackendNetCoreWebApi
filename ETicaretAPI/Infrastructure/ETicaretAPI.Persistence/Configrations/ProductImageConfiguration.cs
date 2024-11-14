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
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            // Primary key ayarı
            builder.HasKey(pi => pi.Id);

            // ImageUrl alanı, 500 karakterden uzun olamaz
            builder.Property(pi => pi.ImageUrl)
                .IsRequired()  // Zorunlu hale getirildi
                .HasMaxLength(500);

            // IsMainImage alanı, varsayılan olarak false olacak
            builder.Property(pi => pi.IsMainImage)
                .HasDefaultValue(false);

            // İlişki: Bir ProductImage bir Product'a ait
            builder.HasOne(pi => pi.Product)
                .WithMany(p => p.ProductImages)
                .HasForeignKey(pi => pi.ProductId);  // ProductImage'taki ProductId ile ilişkileniyor
        }
    }
}
