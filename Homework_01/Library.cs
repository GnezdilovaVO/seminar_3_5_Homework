public static class Library
{
    public static int GetLengthMas(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());

    }
    public static void FeelArray(int[] collection)
    {
        for(int i =0; i < collection.Length; i++)
        {
            collection[i] = new Random().Next(100, 1000);
        }
    }
    public static string PrintArray(int[] massiv)
    {
        string elMassiv = String.Empty;
        for(int i =0; i < massiv.Length; i++)
        {
            elMassiv = elMassiv + massiv[i] + " ";
        }
        return elMassiv;
    }
    public static int SeachEvenNum(int[] massiv2)
    {
        int count = 0;
        for(int i = 0; i <massiv2.Length; i++)
        {
            if(massiv2[i]%2 == 0)
            {
                count = count + 1;
            }
        }
        return count;
    }
} 