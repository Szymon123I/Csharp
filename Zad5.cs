namespace petle
{
    internal class Zad5
    {
        static void Main1(string[] args)
        {
            int[,] macierz = new int[10, 10];
            int suma = 0;
            for (int i = 9; i >= 0; i--)
            {
                for (int j = 9; j >= 0; j--)
                {
                    if (i + j == 9)
                    {
                        macierz[i, j] = 1;
                        suma++;
                    }
                }
            }
            for (int i = 0; i < macierz.GetLength(0); i++)
            {
                for (int j = 0; j < macierz.GetLength(1); j++)
                {
                    Console.Write(macierz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(suma);
        }
    }
}