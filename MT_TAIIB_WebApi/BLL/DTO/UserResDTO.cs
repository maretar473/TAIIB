using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT_TAIIB_WebApi.Model;
using static MT_TAIIB_WebApi.Model.User;

namespace BLL.DTO
{
    internal class UserResDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserGroup Typ { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<OrderResDTO> Orders { get; set; }
        public IEnumerable<BasketPositionResDTO> BasketPositions { get; set; }
    }
}
