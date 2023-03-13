// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


Random random = new Random();
int[,] number = new int[n, m];
Console.WriteLine();

for (int i = 0; i < number.GetLength(0); i++)
{
    for (int j = 0; j < number.GetLength(1); j++)
    {
        number[i, j] = random.Next(10, 100);
        Console.Write(number[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int j = 0; j < number.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < number.GetLength(0); i++)
    {
        sum =sum+ number[i, j];
    }
    Console.Write($"{ sum / number.GetLength(0)} ");
}
Console.ReadLine();