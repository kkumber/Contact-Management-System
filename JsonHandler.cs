using System;
using System.Text.Json;
using System.IO;

namespace ContactManagementSystem
{
    class JsonHandler
    {
        public readonly string JsonFilePath = "contacts.json";

        public List<Person> GetContacts() 
        {
            if (!File.Exists(JsonFilePath))
            {
                File.WriteAllText(JsonFilePath, "[]");
                return new List<Person>();
            }
            else
            {
                string existingJson = File.ReadAllText(JsonFilePath);
                return JsonSerializer.Deserialize<List<Person>>(existingJson) ?? new List<Person>();
            }
         
        }

        public void SaveContacts(List<Person> contacts)
        {
            string json = JsonSerializer.Serialize(contacts, JsonConfig.Options);
            File.WriteAllText(JsonFilePath, json);
        }

    }
}