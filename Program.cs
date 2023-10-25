using System.Console;

namespace CompilerErrors
{
    int x = 23;

    class Program
    {
        public static void Main()
        {
            try
            {
                Utilit.AdditionWihtoutOverflow(int.MaxValue, 25) //I made this method. It is in Utilities and I DO NOT want to move that method into my Program class
            
            catch(Exception e)
            {
                WriteLine(e.Message) //I want it to print: "Cannot Add that big of numbers because of overflow"
            }

            double sum = CompilerErrors.Utilit.AdditionWihtoutOverflow(num1, num2)

            WriteLine($"The sum of {num1} and {num2} is {sum}") //It should print The sum of 4 and 5 is 9
        }
    }
}




