int inputNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int[,] createMatrix(int m, int n)
{
int[,] matrix = new int[m, n];
return matrix;
}


int[,] fillMatrix(int[,] matrix, int minValue, int maxValue)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}


void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}


void findNum(int[,] matrix, int row, int column)
{
   if (row - 1 < 0 
   || row - 1 > matrix.GetLength(0) 
   || column - 1 < 0 
   || column - 1 > matrix.GetLength(1))
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine(matrix[row - 1, column - 1]);
    }
           
}


int m = inputNumber("Введите количество строк");
int n = inputNumber("Введите количество столбцов");
int minValue = inputNumber("Введите минимальное значение");
int maxValue = inputNumber("Введите максимальное значение");
int row = inputNumber("Введите номер строки");
int column = inputNumber("Введите номер столбца");


int[,] matrix = createMatrix(m, n);
int[,] filledMatrix = fillMatrix(matrix, minValue, maxValue);
printMatrix(filledMatrix);
Console.WriteLine();
findNum(filledMatrix, row, column);
