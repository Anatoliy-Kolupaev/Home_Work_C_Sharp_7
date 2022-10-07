// Задача № 47
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int colums = int.Parse(Console.ReadLine());

double [,] array = Array(rows, colums);
PrintArray (array);

double [,] Array (int rows, int colums)
{
    double [,] result = new double [rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
           result[i, j] = Math.Round(new Random().NextDouble() * (colums - rows-1) + rows,1);
        }
    }
    return result;
} 
void PrintArray (double [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0) ; i++)
    {
        for (int j = 0; j < inArray.GetLength(1) ; j++)
        {
            Console.Write(inArray [i, j] + " ");
        }
        Console.WriteLine();
    }
}
