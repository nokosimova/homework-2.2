using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Hello! This is a simple arifmetic calculator");
            Console.WriteLine("Please, enter the required numbers:");
            Console.WriteLine("------------------------------------------");
            Console.Write("num1 = ");
            double operand1 = double.Parse(Console.ReadLine());
            Console.Write("num2 = ");
            double operand2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Now, choose the required operation {+,-,*,/}");
            string sign = Console.ReadLine();
            string error = "Error! Incorrect request";
            switch(sign){
                case "+": Console.WriteLine($"result = {operand1+operand2}");
                break;
                case "-": Console.WriteLine($"result = {operand1-operand2}");
                break;
                case "*": Console.WriteLine($"result = {operand1*operand2}");
                break;
                case "/": {
                    if (operand2 == 0) {
                        Console.WriteLine(error);
                    } else {
                        Console.WriteLine($"result = {operand1 / operand2}");
                    }
                }
                break;
                default: Console.WriteLine(error);
                break;
            }   
            Console.ReadKey();      
        }
    }
}
