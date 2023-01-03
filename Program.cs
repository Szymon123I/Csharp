namespace for_each
{
    internal class Program
{
    static void Main(string[] args)
    {
        int suma = 0;
        int[] dane = new int[100];
        for (int i = 1; i < dane.Length; i++)
            {
                dane[i] = i;
            }
        foreach (int x in dane)
        {
            suma += x;
        }
        Console.WriteLine(suma);
    }
}
}