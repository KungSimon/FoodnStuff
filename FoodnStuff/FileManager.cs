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

        // Method to export class objects to JSON
        public void ExportToJson(Object _object, string baseName, string filePath = "")
        {
            filePath = Path.GetFullPath(filePath); // I think this does what i think it does
            string jsonString = JsonSerializer.Serialize(_object);
            if (filePath == "")
            {
                filePath = Path.Combine("jsonFolder", $"{baseName}.json");
            }
            CreateFolder(filePath);
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
