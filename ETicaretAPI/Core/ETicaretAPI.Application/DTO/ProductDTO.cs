using ETicaretAPI.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.DTO
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
        public Guid BrandId { get; set; }
        public BrandDTO Brand { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryDTO Category { get; set; }
       
        public ICollection<ProductImageDTO> ProductImages { get; set; }
    }
}
//public ICollection<ReviewDTO> Reviews { get; set; }