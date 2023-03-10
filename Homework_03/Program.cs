using static Library;
int lengthArray = GetLength("Задайте длину массива: ");
double[] array = new double[lengthArray];
FeelArray(array);
Console.WriteLine(PrintArray(array));
// Console.WriteLine(EachMin(array));
// Console.WriteLine(EachMax(array));
// Console.WriteLine(EachMax(array) - EachMin(array));
double max1 = EachMax(array);
double min1 = EachMin(array);
Console.WriteLine(max1 + " " + min1 + " " + GetResult(max1, min1));

