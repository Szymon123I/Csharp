using System.Runtime.CompilerServices;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace Csharp
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randNum = rand.Next(0, 9);
            Console.WriteLine("Zgadnij liczbę od 0 do 9");
            int l = Convert.ToInt32(Console.ReadLine());
            if (randNum == l) {
                Console.WriteLine("Udało ci się");
            }
            else
            {
                Console.WriteLine("Unlucky " + randNum);
            }
        }
    }
}
