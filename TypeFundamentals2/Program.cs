namespace TypeFundamentals2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var list = NumberManager.GeneratePrimeNumbersList(5);
            var finalSum = NumberManager.GetIntegerPartOfElementsSum(list);

           Console.WriteLine("Final number:" + finalSum);
           Console.ReadKey();
        }
    }
}
