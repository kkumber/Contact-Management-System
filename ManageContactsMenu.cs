using System;
using System.Collections.Generic;


namespace ContactManagementSystem
{
    class ManageContactsMenu
    {
        public readonly ContactManagement Manager;

        public ManageContactsMenu(ContactManagement manager)
        {
            Manager = manager;
        }


        public void DisplayContacts()
        {       
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Manage Contacts ===");
                if (Manager.Contacts.Count == 0)
                {
                    Console.WriteLine("No contacts found.");
                    Console.WriteLine("Please add contacts to view them.");
                    Console.WriteLine("Press any key to go back...");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine($"Total contacts: {Manager.Contacts.Count}");
                    foreach (Person person in Manager.Contacts)
                    {
                        Console.WriteLine($"{Manager.Contacts.IndexOf(person) + 1}. {person.Nickname}");
                    }
                    Console.WriteLine("\nEnter the number to view contact details or Enter 0 to return to the main menu... ");
                    Console.Write("\nEnter your choice: ");
                    string answer = Console.ReadLine();

                    if (answer == "0")
                    {
                        break;
                    }
                    else
                    {
                        DisplayContactDetails(answer);
                    }
                }
     
            }
        }

        private void DisplayContactDetails(string index)
        {           

            if (!int.TryParse(index, out _))
            {
                Console.WriteLine("Not a number!");
                return;
            }

            // pass the index as param. find the index then display it
            int intIndex = int.Parse(index) - 1; // Convert string to int and adjust for zero-based index

            if ((intIndex + 1) > Manager.Contacts.Count)
            {
                return;
            }


            Person person = Manager.Contacts[intIndex];


            Console.Clear();
            Console.WriteLine("=== Contact Details ===");

            Console.WriteLine($"Nickname: {person.Nickname}");
            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Last Name: {person.LastName}");
            Console.WriteLine($"Contact Number: {person.ContactNumber}");

            Console.WriteLine("\nBack [0]   Edit [1]   Delete [2]");

            char answer = Console.ReadKey().KeyChar;

            while (!AnswerValidation.IsValidContactDetailsNavigationAnswer(answer))
            {
                Console.WriteLine("\nInvalid. Please try again.");
                answer = Console.ReadKey().KeyChar;
            }

            ContactDetailsNavigation(answer, person);
            
        }

        private void ContactDetailsNavigation(char answer, Person person)
        {
            switch (answer) 
            {
                case '1':
                    DisplayEditContactMenu(person);
                    break;
                case '2':
                    DisplayDeleteContactMenu(person);
                    break;
                case '0':
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        private void DisplayEditContactMenu(Person person)
        {
            Console.Clear();
            Console.WriteLine("=== Edit Contact ===");
            // give the list of the current person details and prompt to enter new details or enter to keep current
            Console.WriteLine($"Nickname: {person.Nickname}");
            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Last Name: {person.LastName}");
            Console.WriteLine($"Contact Number: {person.ContactNumber}");

            Console.WriteLine($"\nDo you wish to edit {person.Nickname}'s details?");
            Console.WriteLine("\n [Y] Yes    [Any Key] No");
            char continueEdit = char.ToUpper(Console.ReadKey().KeyChar);

            if (continueEdit != 'Y')
            {
                return;
            }

            EditContactFormAndSave(person);
        }

        private void EditContactFormAndSave(Person person)
        {
            Console.Write("\nEnter new nickname (press Enter to keep current): ");
            string nickname = Console.ReadLine();
            Console.Write("Enter new first name (press Enter to keep current): ");
            string firstName = Console.ReadLine();
            Console.Write("Enter new last name (press Enter to keep current): ");
            string lastName = Console.ReadLine();
            Console.Write("Enter new contact number (press Enter to keep current): ");
            string contactNumber = Console.ReadLine();

            string newNickname = string.IsNullOrWhiteSpace(nickname) ? person.Nickname : nickname;
            string newFirstName = string.IsNullOrWhiteSpace(firstName) ? person.FirstName : firstName;
            string newLastName = string.IsNullOrWhiteSpace(lastName) ? person.LastName : lastName;
            string newContactNumber = string.IsNullOrWhiteSpace(contactNumber) ? person.ContactNumber : contactNumber;

            person.UpdatePerson(newNickname, newFirstName, newLastName, newContactNumber);
            Manager.SaveContactsToJson();

            Console.WriteLine("\nContact Updated!");
            Console.WriteLine($"Nickname: {newNickname}");
            Console.WriteLine($"First Name: {newFirstName}");
            Console.WriteLine($"Last Name: {newLastName}");
            Console.WriteLine($"Contact Number: {newContactNumber}");

            Console.WriteLine("\nPress any key to go back...");
            Console.ReadKey();
        }


        private void DisplayDeleteContactMenu(Person person)
        {
            Console.Clear();
            Console.WriteLine("=== Delete Contact ===");
            Console.WriteLine($"Are you sure you want to delete contact: {person.Nickname}? (Y/N)");
            char answer = Console.ReadKey().KeyChar;
            if (answer == 'Y' || answer == 'y')
            {
                Manager.RemoveContact(person);
                Manager.SaveContactsToJson();
                Console.WriteLine("\nContact deleted successfully.");
            }
            else
            {
                Console.WriteLine("\nDeletion cancelled.");
            }
            Console.WriteLine("Press any key to go back...");
            Console.ReadKey();
        }
    }
}