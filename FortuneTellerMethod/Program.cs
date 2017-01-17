using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fortune Teller!");
            Console.WriteLine("You can quit the program anytime by enter \"QUIT\".");
            Console.WriteLine("You can restart the program anytime by enter \"RESTART\".\n");

            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            QuitOrRestart(firstName);

            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();
            QuitOrRestart(lastName);

            Console.WriteLine("Greetings, " + GreetUser(firstName, lastName) + ". I will tell you your fortune!\n");

            Console.WriteLine("Please enter your age: ");
            string ageStr = Console.ReadLine();
            QuitOrRestart(ageStr);
            int age = int.Parse(ageStr);

            Console.WriteLine("Please enter your birth month (Please enter numbers only): ");
            string birthMonthStr = Console.ReadLine();
            QuitOrRestart(birthMonthStr);
            int birthMonth = int.Parse(birthMonthStr);

            Console.WriteLine("Please enter your favorite ROYGBIV color (Please enter \"HELP\" for a list of the ROYGBIV colors): ");
            string favoriteColor = Console.ReadLine();
            QuitOrRestart(favoriteColor);
            favoriteColor = favoriteColor.ToLower();

            if (favoriteColor == "help")
            {
                Console.WriteLine("The ROYGBIV colors are:\n red\n orange\n yellow\n green\n blue\n indigo\n violet");
                Console.WriteLine("Please enter your favorite: ");
                favoriteColor = Console.ReadLine();
                QuitOrRestart(favoriteColor);
            }

            Console.WriteLine("How many siblings to you have: ");
            string siblingsStr = Console.ReadLine();
            QuitOrRestart(siblingsStr);
            int siblings = int.Parse(siblingsStr);

            Console.WriteLine();
            Console.WriteLine("Your Fortune:");
            Console.WriteLine(GreetUser(firstName, lastName) + " will retire in " + CalculateYearsToRetire(age) + " years, with $" + DetermineMoney(birthMonth) + " in the bank, a vacation home in " + DetermineVacationHome(siblings) + " and a " + DetermineTransportation(favoriteColor) + " as mode of transportation.");
            JudgeFortune();

        }

        static string GreetUser(string firstName, string lastName)
        {
            string name = firstName + " " + lastName;
            return name;
        }

        static int CalculateYearsToRetire(int age)
        {
            int oddOrEven = age % 2;
            int yearsToRetire;
            if (oddOrEven == 0)
            {
                yearsToRetire = 60 - age;
            }
            else
            {
                yearsToRetire = 65 - age;
            }

            return yearsToRetire;
        }

        static string DetermineVacationHome(int siblings)
        {
            string vacationLocation;

            if (siblings < 0)
            {
                vacationLocation = "the dog house";
            }
            else if (siblings == 0)
            {
                vacationLocation = "Florida";
            }
            else if (siblings == 1)
            {
                vacationLocation = "Mexico";
            }
            else if (siblings == 2)
            {
                vacationLocation = "Brazil";
            }
            else if (siblings == 3)
            {
                vacationLocation = "New Zealand";
            }
            else
            {
                vacationLocation = "Australia";
            }

            return vacationLocation;
        }

        static string DetermineTransportation(string favoriteColor)
        {
            string transportation;

            if (favoriteColor == "red")
            {
                transportation = "car";
            }
            else if (favoriteColor == "orange")
            {
                transportation = "boat";
            }
            else if (favoriteColor == "yellow")
            {
                transportation = "plane";
            }
            else if (favoriteColor == "green")
            {
                transportation = "motorcycle";
            }
            else if (favoriteColor == "blue")
            {
                transportation = "bicycle";
            }
            else if (favoriteColor == "indigo")
            {
                transportation = "bus";
            }
            else if (favoriteColor == "violet")
            {
                transportation = "truck";
            }
            else
            {
                transportation = "squeaky shopping cart";
            }

            return transportation;
        }

        static double DetermineMoney(int birthMonth)
        {
            double money;

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                money = 150000.00f;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                money = 750000.00f;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                money = 80000.00f;
            }
            else
            {
                money = 0.00f;
            }

            return money;
        }

        static void JudgeFortune()
        {
            Console.WriteLine("That's a good fortune!");
        }

        static void QuitOrRestart(string input)
        {
            input = input.ToUpper();
            if (input == "QUIT")
            {
                Environment.Exit(0);
            }
            else if (input == "RESTART")
            {
                string[] args = null;
                Main(args);
                Environment.Exit(0);
            }
        }

    }
}
