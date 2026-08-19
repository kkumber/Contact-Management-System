using System;

namespace ContactManagementSystem
{
    class ContactCreationHandler
    {
        public ContactManagement manager;

        public ContactCreationHandler(ContactManagement manager) 
        {
            this.manager = manager;
        }


        public Person CreateContact(string nickname, string firstName, string lastName, string contactNumber)
        {
            Person person = new Person(nickname, firstName, lastName, contactNumber);

            manager.AddContact(person);
            manager.PrintContacts();
            Thread.Sleep(5000);
            return person;
        }

        
    }
}
