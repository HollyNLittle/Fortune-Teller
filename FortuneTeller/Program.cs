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
            //Use ToLower method to ensure case insensitivity.
            String firstName;
            String lastName;
            int age;
            int birthMonth;
            String favoriteColor;
            int numberOfSiblings;
            int yearsToRetire;
            string vacationLocation;
            int accountBalance;
            string transportation;
            Console.WriteLine("\n()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()\n");
            Console.WriteLine("                               FORTUNE TELLER\n\n");
            Console.WriteLine("()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()");
            Console.WriteLine
                ("\n  Hello there! \n\n  My name is Fortune Teller.  \n  Would you like to answer a few questions for me, \n  then I will tell you what I see in your future! ");
            Console.Write("  \n  Would you like that?  Please type yes or no?  ");
            string play = Console.ReadLine().ToLower();

            if (play != "yes")
            {
                Console.WriteLine("  Goodbye! ");
                Console.ReadKey();
            }
            Console.Write("  Great!  What is your first name?  ");
            firstName = Console.ReadLine();
            Console.Write("\n  What is your last name?  ");
            lastName = Console.ReadLine();
            Console.Write
                ("\n  Hello {0} {1} , thank you for playing!  \n\n  How old are you?  ", firstName, lastName);
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n  What is the digit of your birth month?  ");
            birthMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n  What ROYGBIV color do you like the most?  ");
            Console.Write("\n  Would you like me to list the ROYGBIV colors?  If so, enter HELP, if not enter no thanks");
            string help = Console.ReadLine().ToLower();
            if (help == "help")
            {
                Console.WriteLine
                    ("\n     RED\n     ORANGE\n     YELLOW\n     GREEN\n     BLUE\n     INDIGO\n     VIOLET\n     Which color is your favorite?");
            }
            else
            {
                Console.WriteLine("\n     Great!");
            }
            Console.Write("\n  Please enter your favorite color.  ");
            favoriteColor = Console.ReadLine().ToLower();
            Console.Write("\n  One last question, how many siblings do you have?  ");
            numberOfSiblings = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n  Thank you {0}{1} so much for answering all of my questions! \n", (firstName),(lastName));


            //Assign fortune information based on the user's answers.
            //The number of years to retire is based on whether or not the user's age is even.
            if (age % 2 == 0)
            {
                yearsToRetire = 10;
            }
            else
            {
                yearsToRetire = 100;
            }

            //The vacation house location is based on the user's number of siblings.
            switch (numberOfSiblings)
            {
                case 0:
                    vacationLocation = "Montego Bay, Jamaica";
                    break;
                case 1:
                    vacationLocation = "Montreal, Canada";
                    break;
                case 2:
                    vacationLocation = "Mekong, Cambodia";
                    break;
                case 3:
                    vacationLocation = "Monterey, California";
                    break;
                default:
                    vacationLocation = "Cancun, Mexico";
                    break;
            }

            //The mode of transportation is based on the user's favorite color.
            switch (favoriteColor)
            {
                case "red":
                    transportation = "car";
                    break;
                case "orange":
                    transportation = "plane";
                    break;
                case "yellow":
                    transportation = "boat";
                    break;
                case "green":
                    transportation = "limousine";
                    break;
                case "blue":
                    transportation = "bike";
                    break;
                case "indigo":
                    transportation = "helicopter";
                    break;
                case "violet":
                    transportation = "private jet";
                    break;
                default:
                    transportation = "RV";
                    break;

            }

            //The bank account balance amout is based on the user's birth month.
            accountBalance = 100;
            if (age >= 1  && age <= 4)
            {
                accountBalance = 10;
            }
            else if (age >= 5 && age <= 9)
            {
                accountBalance = 100;
            }
            else if (age >= 10 && age <= 12)
            {
                accountBalance = 50;
            }
            else 
            {
                accountBalance = 0;
            }
            
            //Print the user's fortune.
            Console.WriteLine
                ("\n\n  Congratulations, {0} {1}!  \n    I see that You will retire in {2} years, \n    with ${3} in the bank! \n    You will have a grand vacation home in {4}. \n    and use a {5} to get around town.", (firstName),(lastName),(yearsToRetire),(accountBalance),(vacationLocation),(transportation));

            Console.ReadKey();
        }
    }
}
