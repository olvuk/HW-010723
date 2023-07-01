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


void getAverage(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double average = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                {
                    average = average + matrix[i, j];
                }
            
            }
            Console.Write($"{average / matrix.GetLength(0):f2} ");
    }
    

           
}


int m = inputNumber("Введите количество строк");
int n = inputNumber("Введите количество столбцов");
int minValue = inputNumber("Введите минимальное значение");
int maxValue = inputNumber("Введите максимальное значение");


int[,] matrix = createMatrix(m, n);
int[,] filledMatrix = fillMatrix(matrix, minValue, maxValue);
printMatrix(filledMatrix);
Console.WriteLine();
getAverage(matrix);


