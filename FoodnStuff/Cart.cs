using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class Cart
    {
        // We dont transfer products to the cart list, we create a copy of products and their quantity and then subtract this list from our inventory
        public List<Products> ProductsInCart { get; set; } = new List<Products>();
        public Cart()
        {

        }

        public void AddProduct(Products products)
        {
            ProductsInCart.Add(products);
        }
    }
}
