using System;
namespace ConsoleApp01
{
    internal class Program
    {
        public static void Task1()
        {
            Console.Write("Enter your name:\n>");
            string? name = Console.ReadLine();
            Console.Write("Enter your surname:\n>");
            string? surname = Console.ReadLine();

            Console.WriteLine($"Name: {name}, Surname: {surname}");
        }

        public static void Task2()
        {
            DateTime today = DateTime.Today;
            string year = today.ToString("yyyy");
            int yearCurrent = Convert.ToInt32(year);
            Console.Write("Enter your year of birth:\n>");
            string? yearInput = Console.ReadLine();
            try
            {
                int yearOfBirth = Int32.Parse(yearInput);
                Console.WriteLine($"You are {yearCurrent - yearOfBirth} years old");
            }

            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{yearInput}'");
            }


        }

        public static void Task3()
        {
            Console.WriteLine("Enter two numbers");
            Console.Write("First number:\n>");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number:\n>");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public static void Task4()
        {
            Console.Write("Enter number:\n>");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sequence: {number - 1}, {number}, {number + 1}");
        }

        public static void Task5()
        {
            Console.WriteLine("Enter two numbers");
            Console.Write("First number:\n>");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number:\n>");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
        static void Main(string[] args)
        {
            Console.Write("Select Task [1] - [5]:\n>");
            string? input = Console.ReadLine();
            try
            {
                int num = Int32.Parse(input);
                switch (num)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    default:
                        Console.WriteLine($"Entered \"{num}\" - out of range 1 to 5");
                        break;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }

        }

    }
}