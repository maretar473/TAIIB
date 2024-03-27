using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;

namespace BLL
{
    internal interface IBasketPosition
    {
        BasketPositionResDTO AddProductToBasket(int userId, int productId, int quantity);
        void RemoveProductFromBasket(int basketId);
        void UpdateBasketItemQuantity(int basketId, int quantity);
        IEnumerable<BasketPositionResDTO> GetUserBasket(int userId);
        OrderResDTO CreateOrderFromBasket(int userId);
    }
}
