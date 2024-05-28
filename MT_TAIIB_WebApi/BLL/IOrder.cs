using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;

namespace BLL
{
    public interface IOrder
    {
        OrderDTO CreateOrder(int userId);
        IEnumerable<OrderDTO> GetAllOrders();
        IEnumerable<OrderDTO> GetUserOrders(int userId);
        IEnumerable<OrderPositionDTO> GetOrderPositions(int orderId);
    }
}
