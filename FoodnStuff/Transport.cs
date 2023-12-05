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

        // This probably shouldnt be here, it causes recursive loops
        //private ProductManager productManager = ProductManager.GetInstance();

        public Transport(int _id)
        {
            TransportID = _id;
        }

        // Import this list for delivery
        // En funktion som håller i payloaden
        // En funktion som jämför om payload är för stor för capacity
        public void LoadTransport(Order order)
        {
            foreach (Product product in order.InCart)
            {
                ProductsOutOnDelivery.Add(product);
            }
            //Ska merga två listor och loopa igenom för varje item i order listan i product manager
            //Sen ha en ifsats i en metod i prodcut manager och lägga till i transport listan
            Available = false;
        }
        public void Delivered()
        {
            ProductsOutOnDelivery.Clear();
            Available = true;
        }
        public void PayLoad(Order order)
        {
            if (order.CheckTotalOrderQuantity() <= Capacity)
            {
                foreach (Product product in order.InCart)
                {
                    CheckCapacity(product);
                }
            }
            else
            {
                MessageBox.Show("Not enough room, choose a different transport");
            }
        }
        public void CheckCapacity(Product product)
        {
            // En funktion som jämför payloaden med kapaciteten i transporterna
            //foreach (Transport transport in productManager.Transports)
            //{
            //    if (transport.Available && transport.Capacity >= product.Quantity)
            //    {
            //        transport.LoadTransport(order);
            //        return; 
            //    }
            //}
        }
    }
}
