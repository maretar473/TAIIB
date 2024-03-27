using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BLL.DTO;

namespace BLL_EF
{
    internal class BasketPositionServiceEF : IBasketPosition
    {
        public BasketPositionResDTO AddProductToBasket(int userId, int productId, int quantity)
        {
            throw new NotImplementedException();
        }

        public OrderResDTO CreateOrderFromBasket(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BasketPositionResDTO> GetUserBasket(int userId)
        {
            throw new NotImplementedException();
        }

        public void RemoveProductFromBasket(int basketId)
        {
            throw new NotImplementedException();
        }

        public void UpdateBasketItemQuantity(int basketId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
