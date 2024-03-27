using BLL;
using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_EF
{
    internal class OrderServiceEF : IOrder
    {
        public IEnumerable<OrderResDTO> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public OrderResDTO GetOrderById(int orderId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderPositionResDTO> GetOrderPositions(int orderId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderResDTO> GetUserOrders(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
