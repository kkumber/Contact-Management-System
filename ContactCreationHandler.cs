using System;

namespace ContactManagementSystem
{
    class ContactCreationHandler
    {
        public ContactManagement Manager { get; }

        public ContactCreationHandler(ContactManagement manager) 
        {
            Manager = manager;
        }


        public Person CreateContact(string nickname, string firstName, string lastName, string contactNumber)
        {
            Person person = new Person(nickname, firstName, lastName, contactNumber);

            Manager.AddContact(person);
            Manager.SaveContactsToJson();
            Console.WriteLine($"\u001b[1;32m{person.Nickname} created successfully.\u001b[0m");
            Console.WriteLine("\n\u001b[2;37mPress any key to go back...\u001b[0m");
            Console.ReadKey();
            return person;
        }
        
    }
}
