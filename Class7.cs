using System.Runtime.CompilerServices;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace Csharp
{
    internal class Class7
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Podaj a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("A = 0");
            } else
            {
                Console.WriteLine((c - b) / a);
            }
        }
    }
}
