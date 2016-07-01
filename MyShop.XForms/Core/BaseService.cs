using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.XForms.Core
{
    class BaseService
    {
        private static BaseService _instance = null;

        public static BaseService getInstance()
        {
            if (_instance == null) _instance = new BaseService();
            return _instance;
        } 

    }
}
