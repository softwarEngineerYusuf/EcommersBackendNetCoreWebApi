using ETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.DTO
{
    public class OrderDTO
    {
        public Guid CustomerId { get; set; }
        public ICollection<OrderItemDTO> OrderItems { get; set; }
        public decimal TotalPrice { get; set; }
        public ShippingAddressDto ShippingAddress { get; set; }
        public BillingAddressDto BillingAddress { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public ICollection<PaymentDTO> Payments { get; set; }
        public Guid? CouponId { get; set; }
        public CouponDTO Coupon { get; set; }
    }
}
