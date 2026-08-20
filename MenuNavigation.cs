using System;

namespace ContactManagementSystem
{
    class MenuNavigation
    {
        ContactCreationMenu ContactCreationMenu;
        ViewContactsMenu ViewContactsMenu;

        public MenuNavigation(ContactCreationMenu contactCreationMenu, ViewContactsMenu viewContactsMenu)
        {
            ContactCreationMenu = contactCreationMenu;
            ViewContactsMenu = viewContactsMenu;
        }


        public void NavigateBasedOnChoice(char answer)
        {
            switch (answer)
            {
                case '1':
                    ContactCreationMenu.DisplayContactCreationMenu();
                    break;
                case '2': 
                    ViewContactsMenu.DisplayContacts();
                    break;
                case '3':
                    Console.WriteLine("\nEdit Contact selected.");
                    // Call the method to edit a contact
                    break;
                case '4':
                    Console.WriteLine("\nSearch Contact selected.");
                    // Call the method to search for a contact
                    break;
                case '5':
                    Console.WriteLine("\nDelete Contact selected.");
                    // Call the method to delete a contact
                    break;
                case '6':
                    Console.WriteLine("\nExiting the application.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Please try again.");
                    break;
            }
        }
    }
}
