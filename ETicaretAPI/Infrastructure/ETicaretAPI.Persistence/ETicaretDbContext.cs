using ETicaretAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Infrastructure
{
    public class ETicaretDbContext : DbContext
    {
        public ETicaretDbContext(DbContextOptions<ETicaretDbContext> options) : base(options) { }

   
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Product> Products { get; set; }
        
       





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ETicaretDbContext).Assembly);

        }
    }



}


//public DbSet<Address> Addresses { get; set; }
//public DbSet<Review> Reviews { get; set; }
//public DbSet<Coupon> Coupons { get; set; }        
//public DbSet<Order> Orders { get; set; }          
//public DbSet<OrderItem> OrderItems { get; set; }  
//public DbSet<Payment> Payments { get; set; }
//public DbSet<BillingAddress> BillingAddresses { get; set; }
//public DbSet<ShippingAddress> ShippingAddresses { get; set; }
//public DbSet<Customer> Customers { get; set; }



//public DbSet<Cart> Carts { get; set; }
//public DbSet<CartItem> CartItems { get; set; }

//public DbSet<PaymentCardInfo> PaymentCardInfos { get; set; }


