using System;

namespace ContactManagementSystem
{
    class MenuNavigation
    {
        ContactCreationMenu contactCreationMenu;

        public MenuNavigation(ContactCreationMenu contactCreationMenu)
        {
            this.contactCreationMenu = contactCreationMenu;
        }


        public void NavigateBasedOnChoice(char answer)
        {
            switch (answer)
            {
                case '1':
                    this.contactCreationMenu.DisplayContactCreationMenu();
                    // Call the method to add a contact
                    break;
                case '2': 
                    Console.WriteLine("\nView Contacts selected.");
                    // Call the method to view contacts
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
