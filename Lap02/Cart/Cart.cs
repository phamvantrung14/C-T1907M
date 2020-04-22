using System.Collections.Generic;

namespace Lap02.Cart
{
    public class Cart
    {
        private string id;
        private string customer;
        private double grandTotal;
        private List<string> ProductList;
        private string city;
        private string country;

        public Cart()
        {
        }

        public Cart(string id, string customer, double grandTotal, List<string> productList, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.grandTotal = grandTotal;
            ProductList = productList;
            this.city = city;
            this.country = country;
        }
        
        
    }
}