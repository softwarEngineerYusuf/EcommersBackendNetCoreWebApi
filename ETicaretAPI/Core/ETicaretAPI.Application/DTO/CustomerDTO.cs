using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.DTO
{
    public class CustomerDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<AddressDTO> Addresses { get; set; }
        public ICollection<ProductDTO> Favorites { get; set; }
        public CartDTO Cart { get; set; }
        public ICollection<OrderDTO> Orders { get; set; }
        public ICollection<ReviewDTO> Reviews { get; set; }
    }

}
