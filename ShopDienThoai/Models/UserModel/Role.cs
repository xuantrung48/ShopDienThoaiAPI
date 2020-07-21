using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopDienThoai.Models.UserModel
{
    public class Role
    {
        public string RoleId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
