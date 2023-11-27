using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public Cart MyCart { get; set; } = new Cart();

        public User(string _name, string _userName, string _address, string _password, int _id)
        {
            Name = _name;
            Username = _userName;
            Address = _address;
            Password = _password;
            Id = _id;
        }

        // Call this function to override the empty cart with our temporary cart
        public void UseTempCart(Cart _tempCart)
        {
            MyCart = _tempCart;
        }
    }
}
