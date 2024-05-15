using Microsoft.EntityFrameworkCore;
using MT_TAIIB_WebApi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class OrderPositionDTO
    {
        public int Id { get; init; }
        public OrderDTO Order { get; init; }
        public int Amount { get; init; }
        public decimal Price { get; init; }
        public ProductDTO Product { get; init; }
    }
}
