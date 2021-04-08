using System;

namespace _3._0_GC_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = 0;
            string name = "";
            while(string.IsNullOrEmpty(name))
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
            }
            Console.Write("Thank you, "+name+". Please enter and integer between 1 and 100: ");
            while (!int.TryParse(Console.ReadLine(),out inputNum) || (inputNum < 1 || inputNum > 100))
            {
                Console.Write("Invalid. Please enter and integer between 1 and 100, "+name+": ");
            }
            bool isEven = (inputNum % 2 == 0);
            if (inputNum > 60 || !isEven)
            {
                Console.Write(inputNum);
            } 
            if(inputNum < 26 && isEven)
            {
                Console.Write("Even and less than 25.");
            } 
            else if(isEven)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd.");
            }
        }
    }
}
