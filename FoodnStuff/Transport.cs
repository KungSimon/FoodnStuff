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
        public int Capacity { get; set; } = 10;

        public Transport(int _id)
        {
            TransportID = _id;
        }

        // Import this list for delivery
        // En funktion som håller i payloaden
        // En funktion som jämför om payload är för stor för capacity
        public void LoadProducts(Products product)
        {
             ProductsOutOnDelivery.Add(product);
            
            Available = false;
        }
        public void Delivered()
        {
            ProductsOutOnDelivery.Clear();
            Available = true;
        }
    }
}
