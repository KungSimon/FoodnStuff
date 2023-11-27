using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class UserManager
    {
        private List<User> RegisteredCustomers {  get; set; } = new List<User>();
        private List<User> Administrators { get; set; }

        static int UserID { get; set; } = 0;

        public void RegisterCustomer(string _name, string _userName, string _address, string _password)
        {
            var _id = UserID;
            UserID++;
            RegisteredCustomers.Add(new User(_name, _userName, _address, _password, _id));
        }
    }
}
