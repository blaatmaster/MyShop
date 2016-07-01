using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MyShop.XForms.Views;


namespace MyShop.XForms
{
    public class App : Application
    {
        public App()
        {
            LoginView loginView = new LoginView();
            MasterDetailView masterDetailView = new MasterDetailView();
            /*
            NavigationPage navPage = new NavigationPage(mainPage)
            {
                BarTextColor = Color.White,
                BarBackgroundColor = Color.FromHex("#2B84D3")
            };
            */

            MainPage = masterDetailView;
        }

        private void Bootstrap()
        {

        }
    }
}
