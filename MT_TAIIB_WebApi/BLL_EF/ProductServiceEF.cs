using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BLL.DTO;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using MT_TAIIB_WebApi.Model;
using static System.Net.Mime.MediaTypeNames;

namespace BLL_EF
{
    public class ProductServiceEF : IProduct
    {
        private WebshopContext _context = new WebshopContext();

        public ProductServiceEF(WebshopContext context)
        {
            _context = context;
        }
    }
}