using MT_TAIIB_WebApi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class OrderDTO
    {
        public int Id { get; init; }
        public UserDTO User { get; init; }
        public DateTime DateTime { get; init; }
        public IEnumerable<OrderPositionDTO> OrderPositions { get; init; }
    }
}
