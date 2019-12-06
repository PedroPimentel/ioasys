using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoasysApi.ViewModel
{
    public class UserViewModel
    {
        public int userId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool authenticated { get; set; }
    }
}
