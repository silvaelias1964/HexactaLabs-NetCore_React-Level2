﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.Api.DTOs
{
    public class ProductDTO
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal CostPrice { get; set; }

        public decimal SalePrice { get; set; }

        public string ProductTypeId { get; set; }
        public string ProductTypeDesc { get; set; }
        
        public int Stock { get; set; }       

        public string ProviderId { get; set; }
        public string NameProvider { get; set; }
    }
}
