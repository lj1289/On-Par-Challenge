using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnParChallenge
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.Write("Please Enter a number: ");
            //int userInput = int.Parse(Console.ReadLine());
            //int result = 1;

            //Console.WriteLine("To the power of? ");
            //int m = int.Parse(Console.ReadLine());    
            //for(int i = 0; i < m; i++)
            //{
            //    result *= userInput;
            //}
            //Console.WriteLine(result);


            Console.Write("please enter a number: ");
            int userInput = int.Parse(Console.ReadLine());
            Console.Write("your sum is ");
            Console.WriteLine(userInput);


            Console.WriteLine("You like to enter another number (YES/NO)");
            string userResponse = Console.ReadLine().ToUpper();
            
            if (userResponse == "YES")
            {
                Console.WriteLine("Please Enter Another Number ");
                int userInput2 = int.Parse(Console.ReadLine());
                int sum = userInput * userInput2;
                Console.WriteLine(sum);
                Console.ReadKey();
            }
            else if(userResponse == "NO")
            {
                Console.WriteLine("GOODBYE..");
                Console.Clear();
            }
            Console.ReadKey();

            ///---------2nd Problem

            Console.Write("Enter your first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operation");

                      
            string InputSum = Console.ReadLine();

            switch (InputSum)
            {
                case "+":
                    Console.WriteLine();
                    break;
                case "-":
                    Console.WriteLine();
                    break;
                case "*":
                    Console.WriteLine();
                    break;
                case "/":
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Incorrect");
                    break;

            }




        }
    }
}
