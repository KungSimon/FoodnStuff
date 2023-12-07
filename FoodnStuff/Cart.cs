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
        public List<Product> ProductsInCart { get; set; } = new List<Product>();
        public Cart()
        {

        }

        public void AddProduct(Product products)
        {
            ProductsInCart.Add(products);
        }

        public int CalculateCartTotal()
        {
            int total = 0;

            foreach (Product product in ProductsInCart)
            {
                total += product.Price;
            }

            return total;
        }
    }
}
