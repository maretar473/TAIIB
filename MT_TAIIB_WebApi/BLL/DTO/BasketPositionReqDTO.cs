using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    internal class BasketPositionReqDTO
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
    }
}
