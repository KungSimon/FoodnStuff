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
        private static FileManager instance = null;
        private ProductManager productManager;
        private UserManager userManager;
        private BankManager bankManager;

        // File names
        private string ProductManagerInventory = "productManagerInventory";
        private string ProductManagerID = "productManagerID";
        private string UserManagerCustomers = "userManagerCustomer";
        private string UserManagerAdministrators = "userManagerAdministrators";
        private string UserManagerID = "userManagerID";
        private string BankManagerAccounts = "bankManagerAccounts";

        // Folder names
        private string ProductManagerFolder = "jsonFolder";
        private string UserManagerFolder = "jsonFolder";
        private string BankManagerFolder = "jsonFolder";

        // Array to save paths
        private string[] pathDirectory { get; set; } = new string[3] {"jsonFolder","jsonFolder","jsonFolder"};

        private FileManager()
        {
            productManager = ProductManager.GetInstance();
            userManager = UserManager.GetInstance();
            bankManager = BankManager.GetInstance();
        }

        public static FileManager GetInstance()
        {
            if (instance == null)
            {
                instance = new FileManager();
            }
            return instance;
        }

        public void UpdateFolderPath()
        {
            // Function used to update folder paths
            ProductManagerFolder = pathDirectory[0];
            UserManagerFolder = pathDirectory[1];
            BankManagerFolder = pathDirectory[2];
        }

        public void LoadManagers()
        {
            //MessageBox.Show("Got here 1");
            // Look for local directory JSON
            if (FilePathExist("pathDirectory.json"))
            {
                // If json exists then import it into pathDirectory and update your manager paths
                pathDirectory = ImportFromJson<string[]>("pathDirectory.json");
                UpdateFolderPath();
            }
            //MessageBox.Show("Got here 2");
            // Looking for json folders
            if (FolderPathExist(ProductManagerFolder))
            {
                LoadProductManager(productManager);
            }
            if (FolderPathExist(UserManagerFolder))
            {
                LoadUserManager(userManager);
            }
            if (FolderPathExist(BankManagerFolder))
            {
                LoadBankManager(bankManager);
            }
        }

        public void SaveProductManager(List<Product> _products, int _idManager)
        {
            // Inventory
            // IDManager
            var productManagerInventoryJson = ProductManagerInventory;
            var productManagerIDManagerJson = ProductManagerID;
            ExportToJson(_products, productManagerInventoryJson, ProductManagerFolder);
            ExportToJson(_idManager, productManagerIDManagerJson, ProductManagerFolder);
        }
        private void LoadProductManager(ProductManager _productManager)
        {
            if (File.Exists($"{ProductManagerFolder}/{ProductManagerInventory}.json"))
            {
                _productManager.Inventory = ImportFromJson<List<Product>>($"{ProductManagerFolder}/{ProductManagerInventory}.json");
                _productManager.CategorySorter();
            }
            if (File.Exists($"{ProductManagerFolder}/{ProductManagerID}.json")){
                _productManager.ProductID = ImportFromJson<int>($"{ProductManagerFolder}/{ProductManagerID}.json");
            }
        }

        public void SaveUserManager(List<User> _registeredCustomers, List<User> _administrators, int _userID)
        {
            // RegisteredCustomers
            // Administrators
            // UserID
            ExportToJson(_registeredCustomers, UserManagerCustomers, UserManagerFolder);
            ExportToJson(_administrators, UserManagerAdministrators, UserManagerFolder);
            ExportToJson(_userID, UserManagerID, UserManagerFolder);
        }
        private void LoadUserManager(UserManager _userManager)
        {
            if (File.Exists($"{UserManagerFolder}/{UserManagerCustomers}.json"))
            {
                _userManager.RegisteredCustomers = ImportFromJson<List<User>>($"{UserManagerFolder}/{UserManagerCustomers}.json");
            }
            if (File.Exists($"{UserManagerFolder}/{UserManagerAdministrators}.json"))
            {
                _userManager.Administrators = ImportFromJson<List<User>>($"{UserManagerFolder}/{UserManagerAdministrators}.json");
            }
            if (File.Exists($"{UserManagerFolder}/{UserManagerID}.json"))
            {
                _userManager.UserID = ImportFromJson<int>($"{UserManagerFolder}/{UserManagerID}.json");
            }
        }

        public void SaveBankManager(List<BankAccount> _bankAccounts)
        {
            // bankAccounts
            ExportToJson(_bankAccounts, BankManagerAccounts, BankManagerFolder);
        }
        private void LoadBankManager(BankManager bankManager)
        {
            if (File.Exists($"{BankManagerFolder}/{BankManagerAccounts}.json"))
            {
                bankManager.BankAccounts = ImportFromJson<List<BankAccount>>($"{BankManagerFolder}/{BankManagerAccounts}.json");
            }
        }



        public bool FilePathExist(string filePath)
        {
            if (File.Exists(filePath)) return true;
            return false;
        }
        public bool FolderPathExist(string folderPath)
        {
            //MessageBox.Show("Got into FolderPathExist");
            if (Directory.Exists(folderPath)) return true;
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
