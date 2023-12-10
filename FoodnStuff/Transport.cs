using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class Transport
    {
        public List<Product> ProductsOutOnDelivery { get; set; } = new List<Product>();
        public int TransportID { get; set; }
        public bool Available { get; set; } = true;
        public int Capacity { get; set; } = 10;

        public Transport(int _id)
        {
            TransportID = _id;
        }

        public void Delivered()
        {
            ProductsOutOnDelivery.Clear();
            Available = true;
        }
    }
}
