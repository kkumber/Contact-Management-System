using System;
using System.Collections.Generic;


namespace ContactManagementSystem
{
    class ViewContactsMenu
    {
        public readonly List<Person> Contacts;

        public ViewContactsMenu(List<Person> contacts)
        {
            Contacts = contacts;
        }
    }
}