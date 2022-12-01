namespace Csharp
{
    internal class Class6
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Podaj a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Round(a + b,2));
            Console.WriteLine(Math.Round(a - b,2));
            Console.WriteLine(Math.Round(a * b,2));
            Console.WriteLine(Math.Round(a / b,2));
        }
    }
}
