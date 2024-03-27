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
    internal class UserReqDTO
    {
        [MaxLength(100)]
        public string Login { get; set; }
        [MaxLength(100)]
        public string Password { get; set; }
        public UserGroup Typ { get; set; }
        public bool IsActive { get; set; }
    }
}
