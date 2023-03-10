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
            double random = new Random().NextDouble()*9;
            collection[i] = Math.Round(random, 2);
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
    public static double EachMin(double[] massiv2)
    {
        double minArray = massiv2[0];
        for(int i =1; i < massiv2.Length; i++)
        {
            if(massiv2[i] < minArray)
            {
                minArray = massiv2[i];
            }
        }
        return minArray;
    }
    public static double EachMax(double[] massiv3)
    {
        double maxArray = massiv3[0];
        for(int i =1; i < massiv3.Length; i++)
        {
            if(massiv3[i] > maxArray)
            {
                maxArray = massiv3[i];
            }
        }
        return maxArray;
    }
    public static double GetResult(double maximum, double minimum)
    {
        double result = maximum - minimum;
        double result1 = Math.Round(result, 2);
        return result1;
    }
}