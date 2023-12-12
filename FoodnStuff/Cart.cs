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
            MessageBox.Show($"Adding {products}");
            ProductsInCart.Add(products);
        }

        public void MergeCart(Cart cart)
        {
            foreach (Product product in cart.ProductsInCart)
            {
                this.ProductsInCart.Add((Product)product);
            }
        }

        public int CalculateCartTotal()
        {
            int total = 0;

            foreach (Product product in ProductsInCart)
            {
                total += product.Price * product.Quantity;
            }

            return total;
        }

        public void RemoveProduct(Product product)
        {
            if (product == null) {  return; }
            ProductsInCart.Remove(product);
            //Product productToRemove = null;
            //foreach (Product p in ProductsInCart)
            //{
            //    if (p.ID == product.ID)
            //    {
            //        productToRemove = p;
            //        break;
            //    }
            //}
            //
            //if (productToRemove != null)
            //{
            //    var productManager = ProductManager.GetInstance();
            //    foreach (var item in productManager.Inventory)
            //    {
            //        if (item.ID == productToRemove.ID)
            //        {
            //            //item.Quantity += productToRemove.Quantity;
            //            break;
            //        }
            //    }
            //
            //    //productManager.Inventory.Add(productToRemove);
            //
            //    //if (productToRemove.Quantity > product.Quantity)
            //    //{
            //    //    productToRemove.Quantity -= product.Quantity;
            //    //}
            //    //else
            //    //{
            //    //    ProductsInCart.Remove(productToRemove);
            //    //}
            //}

            /*Product productToRemove = ProductsInCart.FirstOrDefault(p => p.ID == product.ID);

            if (productToRemove != null)
            {
                if (productToRemove.Quantity > product.Quantity)
                {
                    productToRemove.Quantity -= product.Quantity;
                }
                else
                {
                    ProductsInCart.Remove(productToRemove);
                }
            }*/
        }

    }
}
