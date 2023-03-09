using static Library;
int lengthArray = GetLengthMas("Введите длину массива: ");
int[] array = new int[lengthArray];
FeelArray(array);
Console.WriteLine(PrintArray(array));
Console.WriteLine("Количество положительных чисел: " + SeachEvenNum(array));