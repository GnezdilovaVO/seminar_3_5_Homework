public static class Library
{
    public static int GetLength(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static void FeelArray(double[] collection)
    {
        for(int i = 0; i < collection.Length; i++)
        {
            collection[i] = new Random().NextDouble();
        }
    }
    public static string PrintArray(double[] massiv)
    {
        string elMassiv = String.Empty;
        for(int i = 0; i < massiv.Length; i++)
        {
            elMassiv = elMassiv + massiv[i] + " ";
        }
        return elMassiv;
    }
}