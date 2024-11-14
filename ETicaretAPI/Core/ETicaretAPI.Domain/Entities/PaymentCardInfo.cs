using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class PaymentCardInfo : BaseEntity
    {
        // Kullanıcıya gösterilebilecek son dört hane
        public string LastFourDigits { get; set; } // Örn: "1234"

        // Kart tipi (Visa, Mastercard gibi), isteğe bağlı
        public string CardType { get; set; }

        // Kart sahibinin adı (isteğe bağlı)
        public string CardHolderName { get; set; }

        // Kullanıcı ile ilişkilendirme
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
