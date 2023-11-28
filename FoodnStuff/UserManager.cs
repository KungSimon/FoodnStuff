using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class UserManager
    {
        public List<User> RegisteredCustomers {  get; set; } = new List<User>();
        // Initializes the Administrator list with one user already in it.
        public List<User> Administrators { get; set; } = new List<User> { new User("admin", "admin", "Administerstreet", "admin", 0) };

        // We create a default admin, and therefore start at 1
        private static int _userID = 1;
        public static int UserID
        {
            get
            {
                // Everytime we get UserID we also increment it
                return _userID++;
            }
            set
            {
                // Makes sure our FileManager is only able to set our userID on startup
                if (_userID == 1)
                {
                    _userID = value;
                }
            }
        }

        public void RegisterCustomer(string _name, string _userName, string _address, string _password)
        {
 
            RegisteredCustomers.Add(new User(_name, _userName, _address, _password, UserID));
        }

        public void RegisterAdministrator(User _User, string _name, string _userName, string _address, string _password)
        {
            // If the user is an administrator then they can add another administrator
            if (Administrators.Exists(u => u == _User))
            {
                Administrators.Add(new User(_name, _userName, _address, _password, UserID));
            }
        }
    }
}
