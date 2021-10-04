using System;

namespace GetToKnowYourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {

            //3 arrays. one with names, hometowns, fave foods.
            //Make sure indexes allign with each other. Using number for all three arrays.

            string[] names = {
                "Justin",
                "Matt",
                "Logan",
                "Raston Gilbert",
                "Yousif",
                "Yash",
                "Chris",
                "Radeen",
                "Josh",
                "Aron",
                "Kasean",
                "Scott Thayer",
                "Delmar",
                "Brandon"

            };
            string[] city =
            {
                "Wyoming, MI",
                "Flint, MI",
                "Plymouth, MI",
                "Zeeland, MI",
                "Oak Park, MI",
                "Detroit, MI",
                "Novi MI",
                "Warren, MI",
                "Northville, MI",
                "Berea, KY",
                "Detroit, MI",
                "Lansing, MI",
                "Detroit, MI",
                "Novi, MI"
            };
            string[] faveFood =
            {
                "Baja Blast",
                "Hot Wings",
                "Funyuns",
                "Vanilla Instant Pudding",
                "Deep Dish Pizza",
                "Hot Cheeto Puffs",
                "Tacos",
                "Mexican",
                "Naleśniki",
                "Sushi",
                "Steak",
                "Nashville Chicken",
                "Vietnamese Food",
                "Sushi"
            };
            int[] faveNumber =
            {
                961,
                4,
                132,
                44,
                13,
                82,
                7,
                0,
                100,
                11,
                99,
                3,
                32
            };
            bool runProgram = true;
            while (runProgram)
            {
                Console.WriteLine("Which student would you like to learn more about? (enter a number 1-13)");
                int student = int.Parse(Console.ReadLine()) - 1;
                if (student + 1 >= 1 && student <= 13)
                {
                    Console.WriteLine($"Student {student + 1} is {names[student]}. What would you like to know about {names[student]}? Enter hometown, favorite food or favorite number");
                    string choice = Console.ReadLine().ToLower();
                    bool invalidStatement = true;
                    while (invalidStatement == true)
                    {
                        if (choice == "hometown")
                        {
                            Console.WriteLine($"{names[student]}'s hometown is {city[student]}.");
                            runProgram = GetYesOrNo("Would you like to know more?  (y/n)");
                            invalidStatement = false;
                        }
                        else if (choice == "favorite food")
                        {
                            Console.WriteLine($"{names[student]}'s favorite food is {faveFood[student]}.");
                            runProgram = GetYesOrNo("Would you like to know more? (y/n)");
                            invalidStatement = false;
                        }
                        else if (choice == "favorite number")
                        {
                            Console.WriteLine($"{names[student]}'s favorite number is {faveNumber[student]}.");
                            runProgram = GetYesOrNo("Would you like to know more?  (y/n)");
                            invalidStatement = false;
                        }
                        else
                        {
                            Console.WriteLine("That data does not exist. Please try again. (enter hometown, favorite food or favorite number)");
                            choice = Console.ReadLine();
                            invalidStatement = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That was not a valid choice.");
                    continue;
                }
            }
        }
        public static bool GetYesOrNo(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine().Trim().ToLower();
                if (input == "y")
                {
                    return true;
                }
                else if (input == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("That input is not valid, please try again!");
                }
            }
        }
    }
}
