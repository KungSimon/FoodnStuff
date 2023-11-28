using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class Products
    {
        public string Category { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int ID { get; set; }
        public int Price { get; set; }

        public Products(string _name, int _price, int _quantity, int _id)
        {
            Name = _name;
            Quantity = _quantity;
            Price = _price;
            ID = _id;
        }        

        public void EditDescription(string _description)
        {
            Description = _description;
        }
    }
}
