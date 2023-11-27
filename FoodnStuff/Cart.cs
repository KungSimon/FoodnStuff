using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class Cart
    {
        public List<Products> ProductsInCart { get; set; } = new List<Products>();
        public Cart() { }
    }
}
