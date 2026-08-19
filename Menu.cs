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
            Console.WriteLine("2. View Contacts");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Search Contact");
            Console.WriteLine("5. Delete Contact");
            Console.WriteLine("6. Exit");

            bool isValidChoice = false;
            char answer = '0';

            while (!isValidChoice)
            {
                Console.WriteLine("\nPlease enter your choice: ");
                ConsoleKeyInfo key = Console.ReadKey();
                answer = key.KeyChar;
                isValidChoice = AnswerValidation.IsValidMainMenuNavigationAnswer(answer);
            }

            MenuNavigation.NavigateBasedOnChoice(answer);
        }
    }
}
