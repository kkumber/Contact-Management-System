using System;

namespace ContactManagementSystem
{
    class Menu
    {
        MenuNavigation MenuNavigation;

        public Menu(MenuNavigation menuNavigation)
        {
            MenuNavigation  = menuNavigation;
        }


        public void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine(@"  ____            _               _    __  __                                   ");
            Console.WriteLine(@" / ___|  ___  ___| |_ _ __ _   _ / \  |  \/  | __ _ _ __   __ _  __ _  ___ _ __ ");
            Console.WriteLine(@" \___ \ / _ \/ __| __| '__| | | / _ \ | |\/| |/ _` | '_ \ / _` |/ _` |/ _ \ '__|");
            Console.WriteLine(@"  ___) |  __/ (__| |_| |  | |_|/ ___ \| |  | | (_| | | | | (_| | (_| |  __/ |   ");
            Console.WriteLine(@" |____/ \___|\___|\__|_|   \__,_/_/   \_\_|  |_|\__,_|_| |_|\__,_|\__, |\___|_|   ");
            Console.WriteLine(@"                                                                  |___/         ");

            Console.WriteLine("[1] Contacts");
            Console.WriteLine("[2] Manage Contacts");
            Console.WriteLine("[3] Exit");

            bool isValidChoice = false;
            char answer = '0';

            while (!isValidChoice)
            {
                Console.Write("\nPress a number (1-3): ");
                ConsoleKeyInfo key = Console.ReadKey();
                answer = key.KeyChar;
                isValidChoice = AnswerValidation.IsValidMainMenuNavigationAnswer(answer);
            }

            MenuNavigation.NavigateBasedOnChoice(answer);
        }
    }
}
