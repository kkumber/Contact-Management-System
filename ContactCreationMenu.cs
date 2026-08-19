using System;

namespace ContactManagementSystem
{
    class ContactCreationMenu
    {

        ContactCreationHandler handler;

        public ContactCreationMenu(ContactCreationHandler handler)
        {
            this.handler = handler;
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
            Console.WriteLine("Contact Creation Form");
            
            Console.WriteLine("Nickname: ");
            string nickname = Console.ReadLine();
            Console.WriteLine("First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Contact Number: ");
            string contactNumber = Console.ReadLine();

            handler.CreateContact(nickname, firstName, lastName, contactNumber);
            return;
        }

        private char GetValidMenuChoice()
        {
            char answer = '0';
            bool isAnswerValid = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Create Contacts");
                Console.WriteLine("\n1. Create Contact");
                Console.WriteLine("2. Back to Main Menu");
                Console.WriteLine("\nPlease enter your choice: ");
                answer = Console.ReadKey().KeyChar;
                isAnswerValid = AnswerValidation.IsOneOrTwo(answer);
            }
            while (!isAnswerValid);
            return answer;
        }


    }
}