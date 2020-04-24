using System.Collections.Generic;

namespace Lap02
{
    public class Cart
    {
        private int id;
        private string customer;
        private double grandTotal;
        private List<Product> productList;
        private string city;
        private string country;

        public Cart(int id, string customer, double grandTotal, List<Product> productList, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.grandTotal = grandTotal;
            this.productList = productList;
            this.city = city;
            this.country = country;
        }

        public void AddProduct(Product product)
        {
            productList.Add(product);
        }

        public void RemoveProduct(Product product)
        {
           productList.Remove(product);
        }

        public double TotalMoney()
        {
            double totalMoney=0;
            for (int i = 0; i < productList.Count; i++)
            {
                totalMoney += productList[i].Price;
            }

            totalMoney += ship(totalMoney);
            this.grandTotal = totalMoney;
            return grandTotal;
        }

        public double ship(double totalMoney)
        {
            if (country.Equals("HN")|| country.Equals("HCM"))
            {
                return totalMoney * 0.1;
            }
            else if (country.Equals("VN"))
            {
                return totalMoney * 0.2;
            }else
            {
                return totalMoney * 0.5;
            }

            return totalMoney;
        }
    }
}