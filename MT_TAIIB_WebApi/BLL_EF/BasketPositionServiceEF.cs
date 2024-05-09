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

        public BasketPositionResDTO AddProductToBasket(int userId, int productId, int quantity)
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

            var basketPosition = user.BasketPositions.FirstOrDefault(bp => bp.Product_Id == productId);
            if (basketPosition != null)
            {
                // If the product already exists in the basket, update the quantity
                basketPosition.Amount += quantity;
            }
            else
            {
                // Otherwise, add a new basket position
                basketPosition = new BasketPosition
                {
                    User_Id = userId,
                    Product_Id = productId,
                    Amount = quantity
                };
                _context.BasketPositions.Add(basketPosition);
            }

            _context.SaveChanges();

            return new BasketPositionResDTO
            {
                UserId = userId,
                ProductId = productId,
                Amount = basketPosition.Amount
            };
        }

        public OrderResDTO CreateOrderFromBasket(int userId)
        {
            var user = _context.Users
                .Include(u => u.BasketPositions)
                .FirstOrDefault(u => u.Id == userId);

            if (user == null)
                throw new ArgumentException("User not found.");

            if (!user.BasketPositions.Any())
                throw new InvalidOperationException("Basket is empty.");

            var order = new Order
            {
                User_Id = userId,
                DateTime = DateTime.Now,
                OrderPositions = user.BasketPositions.Select(bp => new OrderPosition
                {
                    Product_Id = bp.Product_Id,
                    Amount = bp.Amount,
                    Price = bp.Product.Price // Assume product price doesn't change
                }).ToList()
            };

            _context.Orders.Add(order);
            _context.BasketPositions.RemoveRange(user.BasketPositions); // Clear basket after creating order
            _context.SaveChanges();

            return new OrderResDTO
            {
                Id = order.Id,
                UserId = order.User_Id,
                DateTime = order.DateTime
            };
        }

        public IEnumerable<BasketPositionResDTO> GetUserBasket(int userId)
        {
            var userBasket = _context.BasketPositions
                .Where(bp => bp.User_Id == userId)
                .Select(bp => new BasketPositionResDTO
                {
                    UserId = userId,
                    ProductId = bp.Product_Id,
                    Amount = bp.Amount
                })
                .ToList();

            return userBasket;
        }

        public void RemoveProductFromBasket(int basketId)
        {
            var basketPosition = _context.BasketPositions.Find(basketId);
            if (basketPosition == null)
                throw new ArgumentException("Basket position not found.");

            _context.BasketPositions.Remove(basketPosition);
            _context.SaveChanges();
        }

        public void UpdateBasketItemQuantity(int basketId, int quantity)
        {
            var basketPosition = _context.BasketPositions.Find(basketId);
            if (basketPosition == null)
                throw new ArgumentException("Basket position not found.");

            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than 0.");

            basketPosition.Amount = quantity;
            _context.SaveChanges();
        }
    }
}
