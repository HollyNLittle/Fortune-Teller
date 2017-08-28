using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user questions. 
            //Assign user's answers to variables.
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("\nEnter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("\nEnter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the digit of your birth month: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            //Ask user for to select a favorite ROYGBIV color.
            //Ask user to type help if need a list of colors.
            //Use ToLower method to ensure case insensitivity.
            string color;
            Console.WriteLine("\nWhat is your favorite ROYGBIV color?");
            Console.WriteLine("\nEnter HELP to get a list of the ROYGBIV colors, if needed.");
            string answer = Console.ReadLine().ToLower();
            if (answer == "help")
            {
                Console.WriteLine("\nROYGBIV Colors; Red, Orange, Yellow, Green, Blue, Indigo, Violet");
                Console.Write("\nColor? ");
                color = Console.ReadLine();
            }
            else
            {
                color = Console.ReadLine();
            }
            Console.Write("\nHow many siblings do you have? ");
            int siblings = Convert.ToInt32(Console.ReadLine());

            //Assign fortune information based on the user's answers.
            //Assign years to retire based on whether or not the user's age is even.
            int retire;
            int ageDigit = Convert.ToInt32(age);

            if (age % 2 != 0)
            {
                retire = 10;
            }
            else
                retire = 20;

            //Assign mode of transportation based on number of siblings.
            string vacationHome;
            if (siblings == 0)
            {
                vacationHome = "Coronado, Panama";
            }
            else if (siblings == 1)
            {
                vacationHome = "Cotacachi, Ecuador";
            }
            else if (siblings == 2)
            {
                vacationHome = "Central Valley, Costa Rica";
            }
            else if (siblings == 3)
            {
                vacationHome = "Cali, Colombia";
            }
            else if (siblings > 3)
            {
                vacationHome = "Cancun, Mexico";
            }
            else vacationHome = "Avon Lake, Ohio";

            //Use the user's color choice to assign a mode of transportation.
            string transportMode;
            switch (color)
            {
                case "Red":
                    transportMode = "fast car";
                    break;
                case "Orange":
                    transportMode = "private jet";
                    break;
                case "Yellow":
                    transportMode = "stretch limo";
                    break;
                case "Green":
                    transportMode = "private plane";
                    break;
                case "Blue":
                    transportMode = "helicopter";
                    break;
                case "Violet":
                    transportMode = "luxury motorhome";
                    break;
                default:
                    transportMode = "motorcycle";
                    break;
            }

            //Assign the user's bank account balance based on birth month.
            int money;
            if (birthMonth > 1 && birthMonth < 5)
            {
                money = 900000;
            }
            else if (birthMonth < 6 && birthMonth < 9)
            {
                money = 800000;
            }
            else if (birthMonth > 8 && birthMonth < 13)
            {
                money = 700000;
            }
            else
                money = 0;

            //Print the user's fortune.
            Console.WriteLine("\n" + firstName + " " + lastName + " will retire in " + retire +
                " years " + "with " + money + " in the bank, \na vacation home in " +
                vacationHome + " and a " + transportMode + "!");
        }
    }
}
