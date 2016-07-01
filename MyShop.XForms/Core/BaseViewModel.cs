using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.XForms.Core
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public const string TITLE_PROPERTY_NAME = "Title";
        public const string ICON_PROPERTY_NAME = "Icon";
        
        // Title
        private string _title = string.Empty;
        public string Title {
            get { return _title; }
            set { _title = value; }
        }

        // Icon
        private string _icon = "Icon.png";
        public string Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }


        // IMPLEMENTATION => INotifyPropertyChanged 
        ///////////////////////////////////////////
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed(this, new PropertyChangedEventArgs(propertyName));
        }
        
        
    }
}
