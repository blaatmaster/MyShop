using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop.XForms.Core;
using Xamarin.Forms;

namespace MyShop.XForms.Models
{
    class MenuItem: BaseModel
    {
        private string _text = string.Empty;
        private string _icon = string.Empty;
        private Type _pageType = null;
        private Type _viewModelType = null;

        public string Text {
            get { return _text; }
            set { _text = value; }
        }

        public string Icon {
            get { return _icon; }
            set { _icon = value; }
        }

        public Type PageType {
            get { return _pageType; }
            set { _pageType = value; }
        }

        public Type ViewModelType
        {
            get { return _viewModelType; }
            set { _viewModelType = value; }
        }
    }
}
