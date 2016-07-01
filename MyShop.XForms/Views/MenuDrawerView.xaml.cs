using MyShop.XForms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyShop.XForms.Views
{
    public partial class MenuDrawerView : ContentPage
    {
        MenuService menuService = new MenuService();

        MasterDetailView masterDetailView;

        /// <summary>
        /// Constructor
        /// 
        /// TODO: Decouple masterdetailview. 
        /// 
        /// </summary>
        /// <param name="masterDetailView"></param>
        public MenuDrawerView(MasterDetailView masterDetailView)
        {
            this.masterDetailView = masterDetailView;
            InitializeComponent();

            Title = "The Title";
            Icon = "Icon.png";
            
            ListViewMenu.ItemsSource = menuService.getMenuItems();
            ListViewMenu.BackgroundColor = Color.FromHex("#2B84D3");

            ListViewMenu.ItemSelected += masterDetailView.OnItemSelected;
        }

        public void clearSelection()
        {
            ListViewMenu.SelectedItem = null;
        }


    }
}
