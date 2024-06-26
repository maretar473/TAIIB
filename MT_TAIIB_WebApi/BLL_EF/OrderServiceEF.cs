﻿using BLL;
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

        public OrderDTO CreateOrder(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDTO> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderPositionDTO> GetOrderPositions(int orderId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDTO> GetUserOrders(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
