using System;

namespace ContactManagementSystem
{
    class ContactCreationMenu
    {

        ContactCreationHandler Handler { get; }

        public ContactCreationMenu(ContactCreationHandler handler)
        {
            Handler = handler;
        }

        public void DisplayContactCreationMenu()
        {
            while (true) {
                char answer = GetValidMenuChoice();

                if (answer == '1')
                {
                    DisplayContactCreationForm();
                }
                else if (answer == '2')
                {
                    break;
                };
            } 

            
        }

        private void DisplayContactCreationForm()
        {
            Console.Clear();
            Console.WriteLine(@"  ____                _      _   ____            _             ");
            Console.WriteLine(@" / ___|___  ___ _ __ | | ___| |_|  _ \ ___  __ _| |_ ___  _ __ ");
            Console.WriteLine(@"| |   / _ \/ _ \ '_ \| |/ _ \ __| |_) / _ \/ _` | __/ _ \| '__|");
            Console.WriteLine(@"| |__|  __/  __/ |_) | |  __/ |_|  _ <  __/ (_| | || (_) | |   ");
            Console.WriteLine(@" \____\___|\___| .__/|_|\___|\__|_| \_\___|\__,_|\__\___/|_|   ");
            Console.WriteLine(@"               |_|                                              ");

            Console.WriteLine("\u001b[1;33mNickname:\u001b[0m ");
            string nickname = Console.ReadLine();
            Console.WriteLine("\u001b[1;33mFirst Name:\u001b[0m ");
            string firstName = Console.ReadLine();
            Console.WriteLine("\u001b[1;33mLast Name:\u001b[0m ");
            string lastName = Console.ReadLine();
            Console.WriteLine("\u001b[1;33mContact Number:\u001b[0m ");
            string contactNumber = Console.ReadLine();

            Handler.CreateContact(nickname, firstName, lastName, contactNumber);
            return;
        }

        private char GetValidMenuChoice()
        {
            char answer = '0';
            bool isAnswerValid = false;
            do
            {
                Console.Clear();
                Console.WriteLine(@"  ____                _      _   ____            _             ");
                Console.WriteLine(@" / ___|___  ___ _ __ | | ___| |_|  _ \ ___  __ _| |_ ___  _ __ ");
                Console.WriteLine(@"| |   / _ \/ _ \ '_ \| |/ _ \ __| |_) / _ \/ _` | __/ _ \| '__|");
                Console.WriteLine(@"| |__|  __/  __/ |_) | |  __/ |_|  _ <  __/ (_| | || (_) | |   ");
                Console.WriteLine(@" \____\___|\___| .__/|_|\___|\__|_| \_\___|\__,_|\__\___/|_|   ");
                Console.WriteLine(@"               |_|                                              ");
                Console.WriteLine("[1] Create Contact");
                Console.WriteLine("[2] Back to Main Menu");
                Console.WriteLine("\nPlease enter your choice: ");
                answer = Console.ReadKey().KeyChar;
                isAnswerValid = AnswerValidation.IsOneOrTwo(answer);
            }
            while (!isAnswerValid);
            return answer;
        }


    }
}