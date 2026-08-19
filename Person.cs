using System;

namespace ContactManagementSystem
{
    class Person
    {
        public string Nickname { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string ContactNumber { get; private set; }

        public Person(string nickname, string firstName, string lastName, string contactNumber)
        {
            Nickname = nickname;
            FirstName = firstName;
            LastName = lastName;
            ContactNumber = contactNumber;
        }

        public override string ToString()
        {
            return $"Nickname: {Nickname} \nFirst Name: {FirstName} \nLast Name: {LastName} \nContact Number: {ContactNumber}";
        }

    }
}