namespace petle
{
    internal class Zad2
    {
        static void Main1(string[] args)
        {
            int[] dane = new int[10];
            for (int i = 9; i >= 0; i--)
            {
                dane[i] = i;
                Console.WriteLine(dane[i]);
            }
        }
    }
}