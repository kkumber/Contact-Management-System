using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ContactManagementSystem
{ 
    class ContactManagement
    {
        public List<Person> Contacts { get; }
        
        public ContactManagement(List<Person> contacts)
        {
            Contacts = contacts ?? new List<Person>();
        }
        
        public void AddContact(Person contact)
        {
            Contacts.Add(contact);
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