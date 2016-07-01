using MyShop.XForms.Core;
using MyShop.XForms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyShop.XForms.Views
{
    public partial class ProductListView : ContentPage
    {
        ProductService productService = new ProductService();

        public ProductListView()
        {
            InitializeComponent();
            Title = "Product Listview";
            Icon = "Icon.png";
            this.productListView.ItemsSource = productService.getProducts();
        }

    }
}
