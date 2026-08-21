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
            Console.WriteLine("Contact Management System");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Manage Contacts");
            Console.WriteLine("3. Exit");

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
