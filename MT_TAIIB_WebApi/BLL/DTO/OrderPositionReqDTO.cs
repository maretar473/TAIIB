﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class OrderPositionReqDTO
    {
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
    }
}
