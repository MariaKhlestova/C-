// Создать двумерный массив 3х5, состоящий из целых чисел. Вывести на экран.
// Это массив из двух одномерных массивов.
// 1. Надо указать тип данных int[,] table = new int[3,5]; 
// 2. Указать имя массива table
// 3. Выделение памяти под элементы массива new int[3,5]

int[,] matrix = new int[4, 5];
Random rnd = new Random();
// Сформируем цикл, чтобы пройти по строкам двумерного массива
for (int i = 0; i < matrix.GetLength(0); i++)
{
    // Сформируем второй цикл, который позволит обратиться к элементам двумерного массива
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 11);
    }
}
// Нужно перебрать все элементы массива. Воспользуемся циклом for.
for (int i = 0; i < matrix.GetLength(0); i++)
{
    // Сформируем второй цикл, который позволит обратиться к элементам двумерного массива
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}

// Создаем функцию по созданию массива
int[,] CreatMatrix (int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
// Сформируем цикл, чтобы пройти по строкам двумерного массива
for (int i = 0; i < matrix.GetLength(0); i++)
{
    // Сформируем второй цикл, который позволит обратиться к элементам двумерного массива
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 11);
    }
}
return matrix;
}

void ShowMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
{
    // Сформируем второй цикл, который позволит обратиться к элементам двумерного массива
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
} 
}

CreatMatrix(4, 5);
ShowMatrix(matrix);