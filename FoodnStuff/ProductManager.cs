using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class ProductManager
    {
        public List<Products> Inventory { get; set; } = new List<Products>();
        static int IDManager = 0;
        public ProductManager()
        {

        }

        public void CreateProduct(string _name, int _price, int _quantity)
        {
            // Increment ID
            int productID = IDManager;
            IDManager++;
            // This creates a new product and adds it to the inventory
            Inventory.Add(new Products(_name, _price, _quantity, productID));
        }
    }
}
