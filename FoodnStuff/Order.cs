using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class Order
    {
        public List<Products> InCart = new List<Products>();
        public string Address;
        public string Name;

        public Order(List<Products> list, string address, string name)
        {
            
            InCart = list;
            Address = address;
            Name = name;
        }
    }
}
