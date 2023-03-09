using static Library;
int lengthArray = GetLength("Задайте длину массива: ");
double[] array = new double[lengthArray];
FeelArray(array);
Console.WriteLine(PrintArray(array));

