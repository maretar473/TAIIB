using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;

namespace BLL
{
    public interface IBasketPosition
    {
        BasketPositionDTO AddProductToBasket(int userId, int productId, int quantity);
        void RemoveProductFromBasket(int basketId);
        void UpdateBusketItemQuantity(int basketId, int quantity);
        IEnumerable<BasketPositionDTO> GetUserBasket(int userId);
    }
}
