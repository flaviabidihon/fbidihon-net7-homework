using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro___homework
{
    public class Product
    {
        public string name;
        public double price;
        public int quantity;

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public string GetName()
        {
            return this.name;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public int GetQuantity()
        {
            return this.quantity;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }
    }
}
