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
            Console.WriteLine($"{person.Nickname} created successfully.");
            Console.WriteLine("\nPress any key to go back...");
            Console.ReadKey();
            return person;
        }
        
    }
}
