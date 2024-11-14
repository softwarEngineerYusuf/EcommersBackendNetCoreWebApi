using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.DTO
{
    public class CouponDTO
    {
        public string Code { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int MaxUsage { get; set; }
        public int UsageCount { get; set; }
        public ICollection<OrderDTO> Orders { get; set; }
    }
}
