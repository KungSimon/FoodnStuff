using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class Transport
    {
        public List<Products> ProductsOutOnDelivery { get; set; } = new List<Products>();
        public int TransportID { get; set; }
        public bool Available { get; set; } = true;

        public Transport(int _id)
        {
            TransportID = _id;
        }

        // Import this list for delivery
        public void LoadProducts(List<Products> products)
        {
            ProductsOutOnDelivery = products;
            Available = false;
        }

        public void Delivered()
        {
            ProductsOutOnDelivery.Clear();
            Available = true;
        }
    }
}
