using MyShop.XForms.Core;
using MyShop.XForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.XForms.Services
{
    class ProductService : BaseService
    {
        public List<Product> getProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product { Title = "Flat screen 38inch", Price = "832,00", Description = "Normal television"},
                new Product { Title = "Lamborgini", Price = "301.000,00", Description = "Fast car"},
                new Product { Title = "HP Spectre x360", Price = "1.395,00", Description = "Nice looking convertible laptop"},
                new Product { Title = "Volswagen Polo 1.8", Price = "21.000,00", Description = "Regular smaller car"},
            };
            return products;
        }
    }
}
