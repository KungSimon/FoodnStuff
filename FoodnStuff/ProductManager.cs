using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class ProductManager
    {
        // Main list that contains everything available
        public List<Products> Inventory { get; set; } = new List<Products>();
        // Use this dictionary to create a Listbox or something similar and use the keys as category name then grab the list with that key and unpack all products
        public Dictionary<string, List<Products>> CategoryDictionary { get; set; } = new Dictionary<string, List<Products>>();
        public List<string> keyList = new List<string>();
        public List<Order> Orders { get; set; } = new List<Order>(); 

        // IDManager gives the product unique IDs
        public static int IDManager = 0;
        public ProductManager()
        {

        }
        public void AddOrder(Order _order)
        {
            //This is a list of our products in the order
            
            Orders.Add(_order);
        }

        // Function goes through Inventory and sorts them into our dictionary
        private void CategorySorter()
        {
            // Get list of all keys in our category dictionary
            keyList = new List<string>(CategoryDictionary.Keys);
            // Create a list of products that have the same category
            List<Products> CategoryList = new List<Products>();
            string currentKey = string.Empty;
            
            // Makes sure we have an inventory
            if (Inventory.Count <= 0) { return; }

            // This is now redudant code... maybe
            //// Go through every item in our inventory and creates a dictionary using their category as key
            //for (int i = 0; i < Inventory.Count; i++)
            //{
            //    // If the Dictionary does not contain the key then we add it
            //    if (!CategoryDictionary.ContainsKey(Inventory[i].Category))
            //    {
            //        CategoryDictionary.Add(Inventory[i].Category, CategoryList);
            //    }
            //}

            // Go through every item in our inventory and adds it to the dictionary list depending on category
            foreach (Products product in Inventory)
            {
                // If we find the category of product then we take the list and add product to it
                if (CategoryDictionary.TryGetValue(product.Category, value: out var myList))
                {
                    // Adds product to the List
                    myList.Add(product);
                }
                else
                {
                    // If the category/key does not exist then we create it.
                    myList = new List<Products> {product};
                    CategoryDictionary.Add(product.Category, myList);
                }
            }
        }

        public void CreateProduct(string _name, int _price, int _quantity)
        {
            // Increment ID
            int productID = IDManager;
            IDManager++;
            // This creates a new product and adds it to the inventory
            Inventory.Add(new Products(_name, _price, _quantity, productID));
            // Updates categories
            CategorySorter();
        }
    }
}
