using System;
using System.Collections.Generic;

namespace ContactManagementSystem
{ 
    class ContactManagement
    {
        public List<Person> Contacts { get; }

        public ContactManagement()
        {
            Contacts = new List<Person>();
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