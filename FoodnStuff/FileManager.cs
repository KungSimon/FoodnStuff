using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class FileManager
    {
        public ProductManager productManager {  get; set; }
        public UserManager userManager { get; set; }
        public BankManager bankManager { get; set; }
        public FileManager()
        {
            // Take JSON files and recreate our managers... is it ok to pack down our whole managers or just their info?

        }

        public void SaveProductManager()
        {
            // Inventory
            // IDManager
        }

        public void SaveUserManager()
        {
            // RegisteredCustomers
            // Administrators
            // UserID
        }

        public void SaveBankManager()
        {
            // bankAccounts
        }
    }
}
