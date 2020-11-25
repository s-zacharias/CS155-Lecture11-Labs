using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            int response = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Welcome to your phonebook. You made add, delete" +
                "and find phone numbers. Please enter a number corresponding to" +
                "your desired action (1: add, 2: delete, 3: find" +
                "4: exit): " + response);

            while (response != 4)
            {
                switch (response)
                {
                    case 1:
                        string addName = Console.ReadLine();
                        string addNumber = Console.ReadLine();

                        Console.WriteLine("Please enter a name: " + addName);
                        Console.WriteLine("Please enter a number: " + addNumber);

                        phoneBook.Add(addName, addNumber);

                        Console.WriteLine("Thank you. The number has been added.");

                        break;

                    case 2:
                        string deleteName = Console.ReadLine();

                        Console.WriteLine("Please enter a name: " + deleteName);

                        phoneBook.Remove(deleteName);

                        Console.WriteLine("Thank you. The number has been deleted.");

                        break;

                    case 3:
                        string findName = Console.ReadLine();

                        Console.WriteLine("Please enter a name: " + findName);
                        Console.WriteLine(findName + "'s number is " + phoneBook[findName]);

                        break;
                }
            }

            if (response == 4)
            {
                return;
            }
        }
    }
}
