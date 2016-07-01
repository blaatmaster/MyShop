using MyShop.XForms.Core;
using MyShop.XForms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyShop.XForms.Views
{
    public enum MenuType
    {
        Login,
        ShopEdit,
        ProductsList,
        ProductView,
        ProductEdit
    }

    public partial class MasterDetailView : MasterDetailPage
    {
        MenuDrawerView menuDrawerView;
        DashboardView dashboardView;

        // Verzameling van 
        Dictionary<MenuType, NavigationPage> Pages { get; set; }

        public MasterDetailView()
        {
            InitializeComponent();
            Title = "Master/Detail";
            Icon = "Icon.png";

            menuDrawerView = new MenuDrawerView(this);
            dashboardView = new DashboardView();

            Master = menuDrawerView;
            Detail = new NavigationPage(dashboardView);
            IsPresented = false;

            MasterBehavior = MasterBehavior.Split;

            ShowLoginDialog();
        }

        async void ShowLoginDialog()
        {
            var page = new LoginView();
            
            await Navigation.PushModalAsync(page);
        }

        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            Models.MenuItem item = e.SelectedItem as Models.MenuItem;
            if (item != null)
            {
                BaseViewModel viewModel = (BaseViewModel)Activator.CreateInstance(item.ViewModelType);
                Page page = (Page)Activator.CreateInstance(item.PageType);
                page.BindingContext = viewModel;
                Detail = new NavigationPage(page);
                menuDrawerView.clearSelection();
                IsPresented = false;
            }
            
        }
    }
}
