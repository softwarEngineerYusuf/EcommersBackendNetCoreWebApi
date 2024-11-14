﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.DTO
{
    public class ShippingAddressDto
    {
        public Guid Id { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public Guid CustomerId { get; set; }
    }
}