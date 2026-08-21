using System;
using System.Collections.Generic;


namespace ContactManagementSystem
{
    class ManageContactsMenu
    {
        public readonly List<Person> Contacts;
        public readonly ContactManagement Manager;

        public ManageContactsMenu(List<Person> contacts, ContactManagement manager)
        {
            Contacts = contacts;
            Manager = manager;
        }


        public void DisplayContacts()
        {       
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Manage Contacts ===");
                if (Contacts.Count == 0)
                {
                    Console.WriteLine("No contacts found.");
                    Console.WriteLine("Please add contacts to view them.");
                }
                else
                {
                    Console.WriteLine($"Total contacts: {Contacts.Count}");
                    foreach (Person person in Contacts)
                    {
                        Console.WriteLine($"{Contacts.IndexOf(person) + 1}. {person.Nickname}");
                    }
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

        private void DisplayContactDetails(string index)
        {
            
            
                // pass the index as param. find the index then display it
                int intIndex = int.Parse(index) - 1; // Convert string to int and adjust for zero-based index
                Person person = Contacts[intIndex];


                Console.Clear();
                Console.WriteLine("=== Contact Details ===");

                // if it doesnt exist show a message

                if (person == null)
                {
                    Console.WriteLine("Invalid Number");
                    Console.WriteLine("Press any key to return to the contacts list...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"Nickname: {person.Nickname}");
                    Console.WriteLine($"First Name: {person.FirstName}");
                    Console.WriteLine($"Last Name: {person.LastName}");
                    Console.WriteLine($"Contact Number: {person.ContactNumber}");

                    Console.WriteLine("Back [0]   Edit [1]   Delete [2]");

                    char answer = Console.ReadKey().KeyChar;

                    while (!AnswerValidation.IsValidContactDetailsNavigationAnswer(answer))
                    {
                        Console.WriteLine("\nInvalid. Please try again.");
                        answer = Console.ReadKey().KeyChar;
                    }

                    ContactDetailsNavigation(answer, person);
                }

            
            

        }

        private void ContactDetailsNavigation(char answer, Person person)
        {
            switch (answer) 
            {
                case '1':
                    DisplayEditContactMenu(person);
                    break;
                case '2':
                    Console.WriteLine("Delete contact");
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


            Console.Write("Enter new nickname (press Enter to keep current): ");
            string nickname = Console.ReadLine() ?? person.Nickname;
            Console.Write("Enter new first name (press Enter to keep current): ");
            string firstName = Console.ReadLine() ?? person.FirstName;
            Console.Write("Enter new last name (press Enter to keep current): ");
            string lastName = Console.ReadLine() ?? person.LastName;
            Console.Write("Enter new contact number (press Enter to keep current): ");
            string contactNumber = Console.ReadLine() ?? person.ContactNumber;

            Person newContactDetails = new Person(nickname, firstName, lastName, contactNumber);

            person.UpdatePerson(nickname, firstName, lastName, contactNumber);
            Manager.RemoveContact(person);
            Manager.AddContact(newContactDetails);
            Manager.SaveContactsToJson();

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

                Console.WriteLine("\nContact deleted successfully.");
            }
            else
            {
                Console.WriteLine("\nDeletion cancelled.");
            }
        }
    }
}