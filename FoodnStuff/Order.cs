using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class Order
    {
        public List<Product> InCart = new List<Product>();
        public string Address;
        public string Name;

        public Order(List<Product> list, string address, string name)
        {
            InCart = list;
            Address = address;
            Name = name;
        }

        public int CheckTotalOrderQuantity()
        {
            int quantity = 0;
            foreach (Product item in InCart) 
            {
                quantity += item.Quantity;
            }
            return quantity;
        }

        public override string ToString()
        {
            return Address;
        }
    }
}
