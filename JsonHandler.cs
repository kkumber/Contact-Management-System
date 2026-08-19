using System;

namespace ContactManagementSystem
{
    class JsonHandler
    {
        public ContactManagement Manager { get; }
        public bool WriteIndentedOption = true;

        public JsonHandler(ContactManagement contacts) 
        { 
            Manager = contacts;
        }

        // save 1 contact to json on create
        public void SaveContactToJson(Person contact)
        {
           
        }   


        // save all contacts in manager to json on exit
        // save an edited contact or deleted
        // initialize manager with contacts from json on start

    }
}