using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT_TAIIB_WebApi.Model;
using static MT_TAIIB_WebApi.Model.User;

namespace BLL.DTO
{
    public class UserDTO
    {
        public int Id { get; init; }
        public string Login { get; init; }
        public string Password { get; init; }
        public UserGroup Typ { get; init; }
        public bool IsActibe { get; init; }
        public IEnumerable<OrderDTO> Orders { get; init; }
        public IEnumerable<BasketPositionDTO> BasketPositions { get; init; }
    }
}
