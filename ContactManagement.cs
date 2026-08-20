using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ContactManagementSystem
{ 
    class ContactManagement
    {
        public List<Person> Contacts { get; }
        public JsonHandler JsonHandler { get; }

        public ContactManagement(List<Person> contacts, JsonHandler jsonHandler)
        {
            Contacts = contacts;
            JsonHandler = jsonHandler;
        }
        
        public void AddContact(Person contact)
        {
            Contacts.Add(contact);
            JsonHandler.SaveContacts(Contacts);
        }

        public void PrintContacts()
        {
            foreach (Person person in Contacts) 
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

}