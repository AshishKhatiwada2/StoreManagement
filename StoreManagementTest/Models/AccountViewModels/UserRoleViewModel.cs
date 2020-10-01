using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Models.AccountViewModels
{
    public class UserRoleViewModel
    {
        public string ApplicationUserId { get; set; }
        public string RoleName { get; set; }
        public bool IsHaveAccess { get; set; }
        public int CounterId { get; set; }
        
    }
}
