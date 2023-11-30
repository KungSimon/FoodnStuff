using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FoodnStuff
{
    public class FileManager
    {
        // The Idea is to have static managers so even if we create new FileManagers the other managers are static.
        private static ProductManager _productManager = null;
        public ProductManager productManager
        {
            get
            {
                return _productManager;
            }
            set
            {
                if (_productManager == null)
                {
                    _productManager = value;
                }
            }
        }
        private static UserManager _userManager = null;
        public UserManager userManager
        {
            get
            {
                return _userManager;
            }
            set
            {
                if (_userManager == null)
                {
                    _userManager = value;
                }
            }
        }
        private static BankManager _bankManager = null;
        public BankManager bankManager
        {
            get
            {
                return _bankManager;
            }
            set
            {
                if (_bankManager == null)
                {
                    _bankManager = value;
                }
            }
        }

        private string[] pathDirectory { get; set; } = new string[3] {"jsonFolder","jsonFolder","jsonFolder"};

        public FileManager()
        {
            // Look for local directory JSON
            if (filePathExist("pathDirectory.json"))
            {
                // If json exists then import it into pathDirectory
                pathDirectory = ImportFromJson<string[]>("pathDirectory.json");
            }
            // We use pathDirectory to find the other managers, this allows us to save them att different locations
            if (filePathExist(pathDirectory[0]))
            {
                LoadProductManager(productManager, pathDirectory[0]);
            }
            else
            {
                productManager = new ProductManager();
            }
            if (filePathExist(pathDirectory[1]))
            {
                LoadUserManager(userManager, pathDirectory[1]);
            }
            else
            {
                userManager = new UserManager();
            }
            if (filePathExist(pathDirectory[2]))
            {
                LoadBankManager(bankManager, pathDirectory[2]);
            }
            else
            {
                bankManager = new BankManager();
            }
        }

        public void SaveProductManager(List<Products> _products, int _idManager, string _folder)
        {
            // Inventory
            // IDManager
            var productManagerInventoryJson = "productManagerInventoryJSON";
            var productManagerIDManagerJson = "productManagerIDManagerJSON";
            ExportToJson(_products, productManagerInventoryJson, _folder);
            ExportToJson(_idManager, productManagerIDManagerJson, _folder);
        }
        private void LoadProductManager(ProductManager _productManager, string _folder)
        {
            _productManager.ProductID = ImportFromJson<int>($"{_folder}/productManagerProductIDJSON");
            _productManager.Inventory = ImportFromJson<List<Products>>($"{_folder}/productManagerListJSON");
        }

        public void SaveUserManager(List<User> _registeredCustomers, List<User> _administrators, int _userID, string _folder)
        {
            // RegisteredCustomers
            // Administrators
            // UserID
            var userManagerRegisteredCustomers = "userManagerRegisteredCustomerJSON";
            var userManagerAdministrators = "userManagerAdministratorsJSON";
            var userManagerUserID = "userManagerUserIDJSON";
            ExportToJson(_registeredCustomers, userManagerRegisteredCustomers, _folder);
            ExportToJson(_administrators, userManagerAdministrators, _folder);
            ExportToJson(_userID, userManagerUserID, _folder);
        }
        private void LoadUserManager(UserManager _userManager, string _folder)
        {
            _userManager.RegisteredCustomers = ImportFromJson<List<User>>($"{_folder}/userManagerRegisteredCustomerJSON");
            _userManager.Administrators = ImportFromJson<List<User>>($"{_folder}/userManagerAdministratorsJSON");
            _userManager.UserID = ImportFromJson<int>($"{_folder}/userManagerUserIDJSON");
        }

        public void SaveBankManager(List<BankAccount> _bankAccounts, string _folder)
        {
            // bankAccounts
            var bankManagerBankJson = "bankManagerBankJSON";
            ExportToJson(_bankAccounts, bankManagerBankJson, _folder);
        }
        private void LoadBankManager(BankManager bankManager, string _folder)
        {
            bankManager.BankAccounts = ImportFromJson<List<BankAccount>>($"{_folder}/bankManagerBankJSON");
        }



        public bool filePathExist(string filePath)
        {
            if (File.Exists(filePath)) return true;
            return false;
        }
        public T ImportFromJson<T>(string filePath)
        {
            string jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(jsonData);
        }

        // Method to export class objects to JSON
        public void ExportToJson<T>(T _object, string baseName, string folderPath = "jsonFolder")
        {
            folderPath = Path.GetFullPath(folderPath); // I think this does what i think it does
            var filePath = Path.Combine(folderPath, $"{baseName}.json");
            string jsonString = JsonConvert.SerializeObject(_object);
            CreateFolder(folderPath);
            // Write the JSON string to the file.
            File.WriteAllText(filePath, jsonString);
        }

        public void CreateFolder(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }
    }
}
