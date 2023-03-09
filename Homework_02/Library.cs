public static class Library
{
    public static int GetLengthArray(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static void FeelArray(int[] collection)
    {
        for(int i = 0; i < collection.Length; i++)
        {
            collection[i] = new Random().Next(-20, 21);
        }
    }
    public static string PrintArray(int[] massiv)
    {
        string elMassiv = String.Empty;
        for(int i = 0; i < massiv.Length; i++)
        {
            elMassiv = elMassiv + massiv[i] + " ";
        } 
        return elMassiv;
    }
    public static int GetSum(int[] massiv1)
    {
        int count = 0;
        for(int i = 0; i < massiv1.Length; i++)
        {
            if (i%2 == 0)
            {
                count = count + massiv1[i];
            }
        }
        return count;
    }
}