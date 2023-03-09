using static Library;
int lengthArray = GetLengthArray("Задайте длину массива: ");
int[] array = new int[lengthArray];
FeelArray(array);
Console.WriteLine(PrintArray(array));
int result = GetSum(array);
Console.WriteLine("Сумма чисел на нечетных позициях: " + result);

