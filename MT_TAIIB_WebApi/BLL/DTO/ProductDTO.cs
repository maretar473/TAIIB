
using Microsoft.EntityFrameworkCore;
using MT_TAIIB_WebApi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ProductDTO
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public string Image { get; init; }
        public bool IsActive { get; init; }
        public IEnumerable<BasketPositionDTO> BasketPositions { get; init; }
        public IEnumerable<OrderPositionDTO> OrderPosition { get; init; }
    }
}
