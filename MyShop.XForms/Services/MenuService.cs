using MyShop.XForms.Core;
using MyShop.XForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.XForms.Services
{
    class MenuService: BaseService
    {
        

        public List<MenuItem> getMenuItems()
        {
            var menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem
            {
                Icon = "Icon.png",
                Text = "Dashboard",
                PageType = typeof(Views.DashboardView),
                ViewModelType = typeof(ViewModels.DashboardViewModel)
            });
            menuItems.Add(new MenuItem
            {
                Icon = "Icon.png",
                Text = "Products",
                PageType = typeof(Views.ProductListView),
                ViewModelType = typeof(ViewModels.ProductListViewModel)
            });


            //listView.ItemsSource = masterPageItems;
            return menuItems;
        }
    }
}
