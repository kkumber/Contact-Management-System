using System;

namespace ContactManagementSystem
{
    class JsonHandler
    {
        public ContactManagement Manager { get; }

        public JsonHandler(ContactManagement contacts) 
        { 
            Manager = contacts;
        }

        // save 1 contact to json on create
        // save all contacts in manager to json on exit
        // initialize manager with contacts from json on start
    }
}