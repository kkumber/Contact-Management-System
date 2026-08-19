using System;
using System.Collections.Generic;

namespace ContactManagementSystem
{ 
    class ContactManagement
    {
        public List<Person> contacts;

        public ContactManagement()
        {
            contacts = new List<Person>();
        }
        
        public void AddContact(Person contact)
        {
            contacts.Add(contact);
        }

        public void PrintContacts()
        {
            foreach (Person person in contacts) 
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

}