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
            Console.WriteLine($"Contact {person.Nickname} created successfully.");
            Thread.Sleep(5000);
            return person;
        }
        
    }
}
