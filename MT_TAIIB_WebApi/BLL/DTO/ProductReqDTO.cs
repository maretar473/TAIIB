using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ProductReqDTO
    {
        [MaxLength(50)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        [MaxLength(1000)]
        public string Image { get; set; }
        public bool IsActive { get; set; }
    }
}
