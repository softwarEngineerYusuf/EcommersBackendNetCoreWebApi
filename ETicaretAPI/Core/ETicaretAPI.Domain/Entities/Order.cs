using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        public decimal TotalPrice => OrderItems?.Sum(item => item.TotalPrice) ?? 0;

        public Guid ShippingAddressId { get; set; }
        public ShippingAddress ShippingAddress { get; set; }

        public Guid BillingAddressId { get; set; }
        public BillingAddress BillingAddress { get; set; }

        public OrderStatus Status { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public ICollection<Payment> Payments { get; set; }
        public Guid? CouponId { get; set; }
        public Coupon Coupon { get; set; }
    }


    public enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered,
        Canceled
    }

}
