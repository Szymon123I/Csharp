namespace petle
{
    internal class Zad4
    {
        static void Main1(string[] args)
        {
            int[,] macierz = new int[10, 10];
            int suma = 0;
            for (int i = 0; i < macierz.GetLength(0); i++)
            {
                for (int j = 0; j < macierz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        macierz[i, j] = i;
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