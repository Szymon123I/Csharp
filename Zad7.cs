namespace petle
{
    internal class Zad7
    {
        static void Main(string[] args)
        {
            int[,] macierz = new int[10, 10];
            int suma = 0;
            int suma2 = 0;
            for (int i = 0; i < macierz.GetLength(0); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j%2==0)
                    {
                        macierz[i, j] = i;
                        suma = suma + i;
                    }
                    else
                    {
                        macierz[i, j] = i*i;
                        suma2 = suma2 + i*i;
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
            Console.WriteLine(suma2);
        }
    }
}