using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program1();
            //Program2();
            //Program3();
            //Program4();
            Program5();
        }

        private static void Program5()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            bool InputIsDone = false;
            
            Console.WriteLine("Please give me your numbers separated with a comma: ");

            do
            {
                var inputFromUser = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(inputFromUser))
                {
                    String[] removedCommaFromString = inputFromUser.Split(',');
                    if (removedCommaFromString.Length < 5 )
                    {
                        Console.WriteLine("Too few numbers, please try again");
                    }
                    else
                    {
                        InputIsDone = true;
                        var numbers = Array.ConvertAll(removedCommaFromString, int.Parse).ToList();
                        numbers.Sort();
                        Console.WriteLine(numbers[0] + " " + numbers[1] + " " + numbers[2]);
                        numbers.ForEach(number => Console.Write(number + " "));
                    }

                }
                else
                {
                    Console.WriteLine("Empty so invalid, try again:");
                }
            } while (!InputIsDone);
            Console.ReadLine();
        }

        private static void Program4()
        {

            var ListOfNumbers = new List<int>();
            var EndOfInput = false;

            do
            {
                Console.WriteLine("Please type your numbers separated with Enter: ");
                var inputFromUser = Console.ReadLine();

                var inputLowered = inputFromUser.ToLower();

                if (inputLowered.Equals("quit"))
                {
                    EndOfInput = true;
                }
                else if (!String.IsNullOrEmpty(inputFromUser))
                {
                    if (int.TryParse(inputFromUser, out int exit))
                    {
                        ListOfNumbers.Add(Convert.ToInt32(inputFromUser));
                    }
                    else
                    {
                        Console.WriteLine("This is not a number, please try again!");
                    }
                }

            } while (!EndOfInput);

            var ListWithoutDuplicates = ListOfNumbers.Distinct().ToList();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("The typed numbers: ");
            ListOfNumbers.ForEach(number => Console.Write(number + " "));
            Console.WriteLine();
            Console.WriteLine("The numbers without duplicates: ");
            ListWithoutDuplicates.ForEach(number => Console.Write(number + " "));
            Console.ReadLine();
        }

        private static void Program3()
        { 
            Console.WriteLine("Please type 5 different numbers: ");
            var ListOfNumbersFromUser = new List<int>();

            do
            {
                Console.WriteLine("Please type the next number: ");
                var numberFromInput = Convert.ToInt32(Console.ReadLine());

                if (ListOfNumbersFromUser.Contains(numberFromInput))
                {
                    Console.WriteLine("This number has been already typed, please type another one!");
                }
                else
                {
                    ListOfNumbersFromUser.Add(numberFromInput);
                }

            } while (ListOfNumbersFromUser.Count < 5);

            ListOfNumbersFromUser.Sort();
            Console.WriteLine("The 5 numbers sorted: ");
            ListOfNumbersFromUser.ForEach(a => Console.WriteLine(a));
            Console.ReadLine();

        }

        private static void Program2()
        {
            Console.WriteLine("Please type your name to reverse: ");
            var userNameFromInput = Console.ReadLine();

            char[] array = userNameFromInput.ToCharArray();
            Array.Reverse(array);

            var reversedNameAsString = new string(array);
            Console.WriteLine(reversedNameAsString);
            Console.ReadLine();
        }
        private static void Program1()
        {
            bool inputIsFinished = false;
            var ListOfNames = new List<string>();

            do
            {
                Console.WriteLine("Type the names or press Enter to exit ");
                var inputName = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(inputName))
                {
                    inputIsFinished = true;
                }
                else
                {
                    ListOfNames.Add(inputName);
                }
            } while (!inputIsFinished);


            var countOfNames = ListOfNames.Count;

            if (countOfNames == 0)
            {
                
            }
            else if (countOfNames == 1)
            {
                Console.WriteLine(ListOfNames[0] + " likes your post.");
            }
            else if (countOfNames == 2)
            {
                Console.WriteLine(ListOfNames[0] + " and " + ListOfNames[1] + " like your post.");
            }
            else
            {
                Console.WriteLine(ListOfNames[0] + ", " + ListOfNames[1] + " and {0} like your post.",(ListOfNames.Count - 2));
            }

            Console.ReadLine();
        }


    }
}
