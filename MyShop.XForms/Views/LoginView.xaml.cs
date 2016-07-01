using MyShop.XForms.Services;
using MyShop.XForms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyShop.XForms.Views
{
    public partial class LoginView : ContentPage
    {
        //UserService userService = new UserService();

        public LoginView()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);
            //usernameEntry.Text = "kennyvanweeghel";
            //passwordEntry.Text = "abcdefg";
        }
        /*
        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            MasterDetailView masterDetailView = new MasterDetailView();

            string uname = usernameEntry.Text;
            string pwd = passwordEntry.Text;

            if ( userService.checkCredentials( uname, pwd) )
            {
                if(userService.isShopOwner(uname) )
                {
                    //Navigation.InsertPageBefore(new RootPage(), this);
                    //await Navigation.PopAsync();
                    //await ((NavigationPage)Parent).PushAsync(new RootPage());
                }
                else
                {
                    // It's no shop owner (employee or customer)
                }
            }
            
        }
        */
        async void OnAbout(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
