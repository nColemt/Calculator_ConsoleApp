using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter Your Command to Start: ");
            Console.WriteLine("================================");
            Console.WriteLine(" 1 => Addition       | 2 => Subtraction");
            Console.WriteLine(" 3 => Multiplication | 4 => Division");
//          Console.WriteLine(" 5 => Sqaure root    | 6 => Power");
            Console.WriteLine("================================");


            int action = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter First Number: ");

            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");

            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result;


            switch (action)
            {
                case 1:
                    {
                        result = Addition(firstNumber, secondNumber);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(firstNumber, secondNumber);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(firstNumber, secondNumber);
                        break;
                    }
                case 4:
                    {
                        result = Division(firstNumber, secondNumber);
                        break;
                    }
                default:
                    Console.WriteLine("Try another Command!! {1, 2, 3, 4}");
                    break;

            }

            Console.Write("The result is: ", result);

        }


        public static int Addition(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber; //Add
            return result;
        }
        public static int Subtraction(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber; //Substract
            return result;
        }
        public static int Multiplication(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber; //Multiply
            return result;
        }
        public static int Division(int firstNumber, int secondNumber)
        {
            int result = firstNumber / secondNumber; //Divide
            return result;
        }
    }

}