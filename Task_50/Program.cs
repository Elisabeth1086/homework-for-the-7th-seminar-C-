// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");

int a = ReadInt("Введите номер строки матрицы: ");
int b = ReadInt("Введите номер столбца матрицы: ");


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
if (a < 0 | a > number.GetLength(0) - 1 | b < 0 | b > number.GetLength(1) - 1)
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента массива = {number[a, b]}");
}
Console.ReadLine();