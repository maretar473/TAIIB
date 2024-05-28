using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BLL.DTO;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using MT_TAIIB_WebApi.Model;

namespace BLL_EF
{
    internal class BasketPositionServiceEF : IBasketPosition
    {
        private readonly WebshopContext _context;

        public BasketPositionServiceEF(WebshopContext context)
        {
            _context = context;
        }

        public BasketPositionDTO AddProductToBasket(int userId, int productId, int quantity)
        {
            var user = _context.Users
                .Include(u => u.BasketPositions)
                .FirstOrDefault(u => u.Id == userId);

            if (user == null)
                throw new ArgumentException("User not found.");

            var product = _context.Products.Find(productId);
            if (product == null)
                throw new ArgumentException("Product not found.");

            if (!product.IsActive)
                throw new InvalidOperationException("Product is not active.");



            throw new NotImplementedException();
        }

        public IEnumerable<BasketPositionDTO> GetUserBasket(int userId)
        {
            throw new NotImplementedException();
        }

        public void RemoveProductFromBasket(int basketId)
        {
            throw new NotImplementedException();
        }

        public void UpdateBusketItemQuantity(int basketId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
