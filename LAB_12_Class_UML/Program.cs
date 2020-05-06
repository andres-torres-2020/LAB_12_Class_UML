using System;
using System.Collections.Generic;

namespace LAB_12_Class_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> zeroPopulation = new List<Person>();
            ShowList("Empty list test...", zeroPopulation);

            //Create a list of persons in the main method and print those to the screen.
            //Include 3 students and 2 staff in your list of persons.
            List<Person> people = new List<Person>()
            {
                new Student("zzz", "addressZZZ", "schoolZZ", 2010, .75),
                new Staff("Staff-22", "address22", "school22", 28),
                new Staff("Staff-11", "address11", "school11", 27.5),
                //new Student("jjj", "addressJJJ", "schoolJJ", 2010, 1.5),
                new Student("aaa", "addressAAA", "schoolAA", 2011, 2.2),
                new Student("eee", "addressEEE", "schoolEE", 2010, 1.35)
            };
            ShowList("Initial list", people);

            // allow the user to add a student or staff member to
            // the person list
            AddPerson(people);
            ShowList("USER ADDED A PERSON", people);
        }
        public static void ShowList(string message, List<Person> people)
        {
            int i = 0;
            Console.WriteLine(message);
            if (people.Count <= 0)
            {
                Console.WriteLine("Empty list\n");
                return;
            }
            foreach (Person person in people)
            {
                i++;
                Console.WriteLine($"{i} {person.ToString()}");
            }
            Console.WriteLine("");
        }
        public static Person GetPerson()
        {
            return new Person(
                GetInputString("Name: "),
                GetInputString("Address: ")
                );
        }
        public static Staff GetStaff()
        {
            Person p = GetPerson();
            return new Staff(
                p.name,
                p.address,
                GetInputString("School: "),
                ReadDouble("Pay: ", 0, 1000000)
                );
        }
        public static Student GetStudent()
        {
            Person p = GetPerson();
            return new Student(
                p.name,
                p.address,
                GetInputString("Program: "),
                ReadInteger("Year: ", 1900, 3000),
                ReadDouble("Fee: ", 0.0, 1000.0)
                );
        }
        public static Person GetAnyPerson()
        {
            while (true)
            {
                Console.WriteLine("Add Staff or Student? ");
                string input = Console.ReadLine().Trim().ToLower();
                switch (input)
                {
                    case "staff": return GetStaff();
                    case "student": return GetStudent();
                    default:
                        Console.WriteLine("Only expecting staff or student. Try again.");
                        break;
                }
            }
        }
        public static void AddPerson(List<Person> people)
        {
            people.Add(GetAnyPerson());
        }
        #region INPUT METHODS
        public static string ReadString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine().Trim();
        }
        public static bool GetInputBool(string prompt, string[] trueValues, string[] falseValues)
        {
            List<string> acceptableTrueValues = new List<string>(trueValues);
            acceptableTrueValues.Add("t");
            acceptableTrueValues.Add("true");
            List<string> acceptableFalseValues = new List<string>(falseValues);
            acceptableFalseValues.Add("f");
            acceptableFalseValues.Add("false");
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine().Trim().ToLower();
                if (acceptableTrueValues.Exists(input.Equals))
                {
                    return true;
                }
                else if (acceptableFalseValues.Exists(input.Equals))
                {
                    return false;
                }
                Console.WriteLine("t=true/f=false expected!");
            }
        }
        public static DateTime GetInputDate(string message)
        {
            while (true)
            {
                try
                {
                    string input = ReadString(message);
                    if (input.Length > 0)
                    {
                        return DateTime.Parse(input);
                    }
                    throw new Exception("");
                }
                catch
                {
                    Console.WriteLine("Try again!");
                }
            }
        }
        public static string GetInputString(string message)
        {
            while (true)
            {
                try
                {
                    string input = ReadString(message);
                    if (input.Length > 0)
                    {
                        return input;
                    }
                    throw new Exception("");
                }
                catch
                {
                    Console.WriteLine("Try again!");
                }
            }
        }
        public static double ReadDouble(string message, double minValue, double maxValue)
        {
            while (true)
            {
                try
                {
                    double number = -1;
                    string input = ReadString(message);
                    number = double.Parse(input);
                    if (number >= minValue && number <= maxValue)
                    {
                        return number;
                    }
                    throw new Exception("");
                }
                catch
                {
                    Console.WriteLine("Try again");
                }
            }
        }
        public static int ReadInteger(string message, int minValue, int maxValue)
        {
            while (true)
            {
                try
                {
                    int number = -1;
                    string input = ReadString(message);
                    number = int.Parse(input);
                    if (number >= minValue && number <= maxValue)
                    {
                        return number;
                    }
                    throw new Exception("");
                }
                catch
                {
                    Console.WriteLine("Try again");
                }
            }
        }
        #endregion
    }
}

