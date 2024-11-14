using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercentage { get; set; }

        public decimal DiscountedPrice => Price * (1 - (DiscountPercentage / 100));
        public decimal TotalPrice => DiscountedPrice * Quantity;
    }
}
