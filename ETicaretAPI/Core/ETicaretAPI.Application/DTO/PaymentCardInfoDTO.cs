using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.DTO
{
    public class PaymentCardInfoDTO
    {
        public string LastFourDigits { get; set; }
        public string CardType { get; set; }
        public string CardHolderName { get; set; }
        public Guid CustomerId { get; set; }
    }
}
