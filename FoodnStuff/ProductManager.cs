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
        public List<Transport> Transports { get; set; }

        // IDManager gives the product unique IDs
        private static int productID = 0;
        public int ProductID
        {
            get
            {
                return productID++;
            }
            set
            {
                if (productID == 0)
                {
                    productID = value;
                }
            }
        }
        public ProductManager()
        {

        }


        // Function that adds the product to cart
        public void AddToCart(Cart _myCart, Products _product, int _quantity)
        {
            // Uses secondary constructor of Products to create a copy with new quantity
            Products cartProduct = new Products(_product, _quantity);
            _myCart.AddProduct(cartProduct);
        }

        // Function doesnt require login and therefor works for both logged in and anonoymous users 
        public bool AddOrder(Cart _checkoutCart, string _myAddress, string _myName)
        {
            // Fail checking
            if (_checkoutCart == null || _checkoutCart.ProductsInCart.Count == 0) return false;
            //This is a list of our products in the order
            
            // Creates new Order and adds it to the Order list
            Orders.Add(new Order(_checkoutCart.ProductsInCart, _myAddress, _myName));
            // Returns true if successfully added order otherwise false
            return true;
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

        public void CreateProduct(string _category, string _name, int _price, int _quantity)
        {
            // Increment ID
            int productID = ProductID;
            // This creates a new product and adds it to the inventory
            Inventory.Add(new Products(_category, _name, _price, _quantity, productID));
            MessageBox.Show($"{Inventory.Count} has been added");
            // Updates categories
            CategorySorter();
        }
    }
}
