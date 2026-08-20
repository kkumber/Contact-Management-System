

namespace ContactManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load contacts from JSON file
            JsonHandler jsonHandler = new JsonHandler();
            List<Person> contacts = jsonHandler.GetContacts();

            // Initialize the contact management system
            ContactManagement manager = new ContactManagement(contacts);


            ContactCreationHandler creationHandler = new ContactCreationHandler(manager);
            ContactCreationMenu creationMenu = new ContactCreationMenu(creationHandler);
            MenuNavigation menuNavigation = new MenuNavigation(creationMenu);
            Menu menu = new Menu(menuNavigation);
            

            bool running = true;


            while (running)
            {
                menu.DisplayMainMenu();
            }
        }
    }
}
