using BLL;
using BLL.DTO;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_EF
{
    internal class OrderServiceEF : IOrder
    {
        private readonly WebshopContext _context;

        public OrderServiceEF(WebshopContext context)
        {
            _context = context;
        }

        public IEnumerable<OrderResDTO> GetAllOrders()
        {
            var orders = _context.Orders
                .Include(o => o.OrderPositions)
                .Select(o => new OrderResDTO
                {
                    Id = o.Id,
                    UserId = o.User_Id,
                    DateTime = o.DateTime,
                    OrderPositions = o.OrderPositions.Select(op => new OrderPositionResDTO
                    {
                        Id = op.Id,
                        OrderId = op.Order_Id,
                        Amount = op.Amount,
                        Price = op.Price,
                        ProductId = op.Product_Id
                    })
                })
                .ToList();

            return orders;
        }

        public OrderResDTO GetOrderById(int orderId)
        {
            var order = _context.Orders
                .Include(o => o.OrderPositions)
                .FirstOrDefault(o => o.Id == orderId);

            if (order == null)
                throw new ArgumentException("Order not found.");

            var orderDTO = new OrderResDTO
            {
                Id = order.Id,
                UserId = order.User_Id,
                DateTime = order.DateTime,
                OrderPositions = order.OrderPositions.Select(op => new OrderPositionResDTO
                {
                    Id = op.Id,
                    OrderId = op.Order_Id,
                    Amount = op.Amount,
                    Price = op.Price,
                    ProductId = op.Product_Id
                })
            };

            return orderDTO;
        }

        public IEnumerable<OrderPositionResDTO> GetOrderPositions(int orderId)
        {
            var order = _context.Orders
                .Include(o => o.OrderPositions)
                .FirstOrDefault(o => o.Id == orderId);

            if (order == null)
                throw new ArgumentException("Order not found.");

            var orderPositionsDTO = order.OrderPositions.Select(op => new OrderPositionResDTO
            {
                Id = op.Id,
                OrderId = op.Order_Id,
                Amount = op.Amount,
                Price = op.Price,
                ProductId = op.Product_Id
            }).ToList();

            return orderPositionsDTO;
        }

        public IEnumerable<OrderResDTO> GetUserOrders(int userId)
        {
            var userOrders = _context.Orders
                .Where(o => o.User_Id == userId)
                .Include(o => o.OrderPositions)
                .Select(o => new OrderResDTO
                {
                    Id = o.Id,
                    UserId = o.User_Id,
                    DateTime = o.DateTime,
                    OrderPositions = o.OrderPositions.Select(op => new OrderPositionResDTO
                    {
                        Id = op.Id,
                        OrderId = op.Order_Id,
                        Amount = op.Amount,
                        Price = op.Price,
                        ProductId = op.Product_Id
                    })
                })
                .ToList();

            return userOrders;
        }
    }
}
