using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.DTO
{
    public class CartDTO
    {
        public Guid CustomerId { get; set; }
        public ICollection<CartItemDTO> CartItems { get; set; }
    }
}
