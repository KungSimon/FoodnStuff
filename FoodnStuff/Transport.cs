using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FoodnStuff
{
    public class Transport
    {
        public List<Order> OrdersOutOnDelivery { get; set; } = new List<Order>();
        public int TransportID { get; set; }
        public bool Available { get; set; } = true;
        public int Capacity { get; set; } = 0;
        public int MaxCapacity { get; set; } = 10;
        public string Info
        {
            get
            {
                return GetInfo();
            }
        }

        public Transport(int _id)
        {
            TransportID = _id;
        }

        public void Delivered()
        {
            OrdersOutOnDelivery.Clear();
            Capacity = 0;
            Available = true;
        }
        private string GetInfo()
        {
            string availability = Available ? "available" : "out on delivery";
            return $"Truck:{TransportID.ToString()}\tCapacity: {Capacity.ToString()}\tStatus: {availability}";
        }


        public override string ToString()
        {
            return TransportID.ToString();
        }
    }
}
