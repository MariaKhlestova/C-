// Задача: сформировать двумерный массив из целых чисел.
// Вывести на экран "интересные" элементы (если сумма цифр чисел - четная).

int[,] CreatMatrix (int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 1000);
    }
}
return matrix;
}

void ShowMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
} 
}

int[,] matrix = CreatMatrix(3,4);

ShowMatrix(matrix);

foreach(int e in matrix)
{
    if (isinteresting(e) == true)
    {
        Console.WriteLine($"{e} ");
    }
}

bool isinteresting(int value)
{
    int SumOfDigits = GetSumOfDigits(value);
    if (SumOfDigits % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}


