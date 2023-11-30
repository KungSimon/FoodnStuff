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
        public ProductManager productManager {  get; set; }
        public UserManager userManager { get; set; }
        public BankManager bankManager { get; set; }
        public FileManager()
        {
            // Look for local directory JSON
        }

        public void SaveProductManager(List<Products> _products, int _idManager)
        {
            // Inventory
            // IDManager
            var productManagerInventoryJson = "productManagerInventoryJSON";
            var productManagerIDManagerJson = "productManagerIDManagerJSON";
            ExportToJson(_products, productManagerInventoryJson);
            ExportToJson(_idManager, productManagerIDManagerJson);
        }
        public void LoadProductManager(ProductManager _productManager)
        {
            _productManager.ProductID = ImportFromJson<int>("jsonFolder/productManagerProductIDJSON");
            _productManager.Inventory = ImportFromJson<List<Products>>("jsonFolder/productManagerListJSON");
        }

        public void SaveUserManager(List<User> _registeredCustomers, List<User> _administrators, int _userID)
        {
            // RegisteredCustomers
            // Administrators
            // UserID
            var userManagerRegisteredCustomers = "userManagerRegisteredCustomerJSON";
            var userManagerAdministrators = "userManagerAdministratorsJSON";
            var userManagerUserID = "userManagerUserIDJSON";
            ExportToJson(_registeredCustomers, userManagerRegisteredCustomers);
            ExportToJson(_administrators, userManagerAdministrators);
            ExportToJson(_userID, userManagerUserID);


        }

        public void SaveBankManager(List<BankAccount> _bankAccounts)
        {
            // bankAccounts
            var bankManagerBankJson = "bankManagerBankJSON";
            ExportToJson(_bankAccounts, bankManagerBankJson);

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
