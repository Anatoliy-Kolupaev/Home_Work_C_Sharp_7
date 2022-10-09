// Задача № 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
Console.WriteLine("Задайте пожалуйста массив.");
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = int.Parse(Console.ReadLine());

int [,] array = UserArray (rows, column);
PrintArray(array);

Console.Write("Введите № строки искуемого элемента: ");
int positionRows = int.Parse(Console.ReadLine());
Console.Write("Введите № столбца искуемого элемента: ");
int positionColumn = int.Parse(Console.ReadLine());
Position(positionRows, positionColumn);

int [,] UserArray(int rows, int column)
{
    int [,] result = new int [rows, column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column ; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
void PrintArray (int [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray [i, j] + " ");
        }
        Console.WriteLine();
    }
}
void Position (int positionRows, int positionColumn)
{
    if (positionRows <= rows && positionColumn <= column)
    {
        Console.Write($"значение элемента = {array[positionRows -1, positionColumn-1]}");
    }
    else Console.WriteLine($"{positionRows + " " + positionColumn} - такой позииции в массиве нет");
}
