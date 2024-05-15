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

    }
}
