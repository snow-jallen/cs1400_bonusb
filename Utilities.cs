namespace CompilerErrors
{
    int i = 4;

    class Utilities
    {
        private int AdditionWihtoutOverflow(int num1, int num2)
        {
            double doubleSum = (double)num1 + num2;

            if(doubleSum == num1 + num2)
            {
                return num1 + num2
            }
            else
            {
                Console.WriteLine("Cannot Add that big of numbers because of overflow")
            }
        }
    }
}

