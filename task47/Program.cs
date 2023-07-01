int inputNumber(string message) 
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double[,] createMatrix(int m, int n)
{
double[,] matrix = new double[m, n];
return matrix;
}

double[,] fillMatrix(double[,] matrix, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] =  Math.Round(rnd.NextDouble() * (maxValue - minValue) + minValue, 2);
        }
    }
    return matrix;
}

void printMatrix(double[,] matrix)
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



int m = inputNumber("Введите количество строк");
int n = inputNumber("Введите количество столбцов");
int minValue = inputNumber("Введите минимальное значение");
int maxValue = inputNumber("Введите максимальное значение");

double[,] matrix = createMatrix(m, n);
double[,] filledMatrix = fillMatrix(matrix, minValue, maxValue);
printMatrix(filledMatrix);