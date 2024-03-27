using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;

namespace BLL
{
    internal interface IOrder
    {
        IEnumerable<OrderResDTO> GetAllOrders();
        IEnumerable<OrderResDTO> GetUserOrders(int userId);
        OrderResDTO GetOrderById(int orderId);
        IEnumerable<OrderPositionResDTO> GetOrderPositions(int orderId);
    }
}
