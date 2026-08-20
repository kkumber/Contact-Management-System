using System;
using System.Collections.Generic;


namespace ContactManagementSystem
{
    class ViewContactsMenu
    {
        public readonly List<Person> Contacts;

        public ViewContactsMenu(List<Person> contacts)
        {
            Contacts = contacts;
        }

        public void DisplayContacts()
        {       
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== View Contacts ===");
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
            }
            else
            {
                Console.WriteLine($"Nickname: {person.Nickname}");
                Console.WriteLine($"First Name: {person.FirstName}");
                Console.WriteLine($"Last Name: {person.LastName}");
                Console.WriteLine($"Contact Number: {person.ContactNumber}");
            }

           
            Console.WriteLine("\nPress any key to return to the contacts list...");
            Console.ReadKey();
        }
    }
}