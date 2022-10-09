// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = int.Parse(Console.ReadLine());
int[,] array = Array(rows, column);
PrintArray(array);
for (int i = 0; i < column; i++)
{
    double sum = 0;
    for (int j = 0; j < rows; j++)
    {
        sum = sum + array[j, i];
    }
    sum = Math.Round(sum / rows, 1);
    Console.WriteLine($"Среднее арифметическое cтолбца № {i + 1} = {sum}");
}
int[,] Array(int rows, int column)
{
    int[,] result = new int[rows, column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}