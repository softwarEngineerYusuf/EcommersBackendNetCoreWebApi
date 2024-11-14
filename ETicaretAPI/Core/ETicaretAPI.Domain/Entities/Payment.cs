using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public decimal Amount { get; set; }
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get; set; }

        public Guid? PaymentCardInfoId { get; set; }
        public PaymentCardInfo PaymentCardInfo { get; set; }
    }

    
    public enum PaymentStatus
    {
        Unpaid,
        Paid,
        Refunded
    }

   
    public enum PaymentMethod
    {
        CreditCard,
        PayPal,
        BankTransfer
    }
}
