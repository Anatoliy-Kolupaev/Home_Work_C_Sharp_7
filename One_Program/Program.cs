System.Console.WriteLine("Добрый день!");
int n = 0;
int v = 100;
while (n < v)
{
    Console.Write("Выберите задачу которую хотите проверить (задачи пронумерованы 47, 50, 52):  ");
    int choice = int.Parse(Console.ReadLine());
    while (choice == 47)
    {
        Console.WriteLine();
        Console.WriteLine("Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
        Console.WriteLine();
        if (choice == 47) task47();
        if (choice == 47) task47();
        if (choice == 47) task47();
        break;

    }
    while (choice == 50)
    {
        Console.WriteLine();
        Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
        Console.WriteLine();
        if (choice == 50) task50();
        if (choice == 50) task50();
        if (choice == 50) task50();
        break;
    }
    while (choice == 52)
    {
        Console.WriteLine();
        Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
        Console.WriteLine();
        if (choice == 52) task52();
        if (choice == 52) task52();
        if (choice == 52) task52();
        break;
    }
    n++;
}

void task47()
{
    Console.WriteLine("Задайте пожалуйста массив.");
    Console.Write("Введите кол-во строк: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Введите кол-во столбцов: ");
    int colums = int.Parse(Console.ReadLine());

    double[,] array = Array(rows, colums);
    PrintArray(array);

    double[,] Array(int rows, int colums)
    {
        double[,] result = new double[rows, colums];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                result[i, j] = Math.Round(new Random().NextDouble() * (colums - rows - 1) + rows, 1);
            }
        }
        return result;
    }
    void PrintArray(double[,] inArray)
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

}
void task50()
{
    Console.WriteLine("Задайте пожалуйста массив.");
    Console.Write("Введите кол-во строк: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Введите кол-во столбцов: ");
    int column = int.Parse(Console.ReadLine());

    int[,] array = UserArray(rows, column);
    PrintArray(array);

    Console.Write("Введите № строки искуемого элемента: ");
    int positionRows = int.Parse(Console.ReadLine());
    Console.Write("Введите № столбца искуемого элемента: ");
    int positionColumn = int.Parse(Console.ReadLine());
    Position(positionRows, positionColumn);

    int[,] UserArray(int rows, int column)
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
    void Position(int positionRows, int positionColumn)
    {
        if (positionRows <= rows && positionColumn <= column)
        {
            Console.Write($"значение элемента = {array[positionRows - 1, positionColumn - 1]}");
            Console.WriteLine();
        }
        else Console.WriteLine($"{positionRows + " " + positionColumn} - такой позииции в массиве нет");
        Console.WriteLine();
    }
}
void task52()
{
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
}