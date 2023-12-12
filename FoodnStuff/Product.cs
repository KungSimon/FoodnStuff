using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class Product
    {
        public string Category { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int ID { get; set; }
        public int Price { get; set; }
        public string DisplayInfo
        {
            get
            {
                return GetDisplayInfo();
            }
        }

        public Product()
        {

        }
        public Product(string _category, string _name, int _price, int _quantity, int _id)
        {
            Category = _category;
            Name = _name;
            Quantity = _quantity;
            Price = _price;
            ID = _id;
        }
        public Product(Product _originalProduct, int _orderQuantity)
        {
            Name = _originalProduct.Name;
            Quantity = _orderQuantity;
            Price = _originalProduct.Price;
            ID = _originalProduct.ID;
            Description = _originalProduct.Description;
            Category = _originalProduct.Category;
        }
        public void EditDescription(string _description)
        {
            Description = _description;
        }
        public override string ToString()
        {
            return Name;
        }
        private string GetDisplayInfo()
        {
            return $"{Name.PadRight(20)}\tPrice: {Price.ToString("C").PadRight(20)}\tStock: {Quantity.ToString().PadRight(20)}";
        }
        public string GetInfo()
        {
            return $"Stock: {Quantity.ToString().PadRight(20)}\tPrice: {Price.ToString("C").PadRight(20)}\tCategory: {Category.ToString().PadRight(20)}";
        }
    }
}
