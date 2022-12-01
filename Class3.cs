namespace Csharp
{
    internal class Class3
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Podaj r: ");
            double r = Convert.ToDouble(Console.ReadLine());
            float pi = (float)Math.PI;
            double obj = Convert.ToDouble((4.0/3)*pi*(r*r*r));
            Console.WriteLine(Math.Round(obj,2));
        }
    }
}
