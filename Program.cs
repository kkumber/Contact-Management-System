

namespace ContactManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactManagement manager = new ContactManagement();
            ContactCreationHandler creationHandler = new ContactCreationHandler(manager);
            ContactCreationMenu creationMenu = new ContactCreationMenu(creationHandler);
            MenuNavigation menuNavigation = new MenuNavigation(creationMenu);
            Menu menu = new Menu(menuNavigation);
            JsonHandler jsonHandler = new JsonHandler(manager);

            bool running = true;

            while (running)
            {
                menu.DisplayMainMenu();
            }
        }
    }
}
