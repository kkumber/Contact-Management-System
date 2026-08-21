using System;

namespace ContactManagementSystem
{
    class MenuNavigation
    {
        ContactCreationMenu ContactCreationMenu;
        ManageContactsMenu ManageContactsMenu;

        public MenuNavigation(ContactCreationMenu contactCreationMenu, ManageContactsMenu manageContactsMenu)
        {
            ContactCreationMenu = contactCreationMenu;
            ManageContactsMenu = manageContactsMenu;
        }


        public void NavigateBasedOnChoice(char answer)
        {
            switch (answer)
            {
                case '1':
                    ContactCreationMenu.DisplayContactCreationMenu();
                    break;
                case '2': 
                    ManageContactsMenu.DisplayContacts();
                    break;
                case '3':
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
