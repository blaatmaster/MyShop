using MyShop.XForms.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.XForms.Services
{
    class UserService : BaseService
    {

        public UserService()
        {
        }

        public bool checkCredentials(string username, string password)
        {
            return true;
        }

        public bool hasUser(string username)
        {
            return true;
        }

        public bool isShopOwner(string username)
        {
            return true;
        }

    }
}
