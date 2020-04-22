using System.Collections.Generic;

namespace T1907M.Lab_2_3
{
    public class Cart
    {
        private int id;
        private string customer;
        private double grandTotal;
        private List<Product> listProduct;
        private string city;
        private string country;

        public Cart(int id, string customer, double grandTotal, List<Product> listProduct, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.grandTotal = grandTotal;
            this.listProduct = listProduct;
            this.city = city;
            this.country = country;
        }

        public bool AddProduct(Product product)
        {
            listProduct.Add(product);
            //them tien trong grandtotal
            return true;
        }

        public bool RemoveProduct(Product product)
        {
            //tru tien trong GrandTotal
            return listProduct.Remove(product);
        }

        public double FinalTotal()
        {
            double grand = 0;
            foreach (var p in listProduct)
            {
                grand += p.Price;
                this.grandTotal = grand;
            }

            /*if (country.Equals("VN")&&(city.Equals("HN")||city.Equals("HCM")))
            {
                 grand *= 1.01;
            }else if (country.Equals("VN"))
            {
                grand *= 1.02;
            }
            else
            {
                grand *= 1.05;
            }*/
            grand += ShippingFee(grand);

            this.grandTotal = grand;
            return grandTotal;
        }

        public double ShippingFee(double grand)
        {
            if (country.Equals("VN")&&(city.Equals("HN")||city.Equals("HCM")))
            {
                return grand *0.01;
            }else if (country.Equals("VN"))
            {
                return grand * 0.02;
            }
            else
            {
                return grand *0.05;
            }
        }
    }
}