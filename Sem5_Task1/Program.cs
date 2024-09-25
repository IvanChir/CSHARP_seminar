// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3     4 3 16 3
// 4 3 4 1 =>  4 3 4 1
// 2 9 5 4     4 9 25 4


// скопируем функции с пред. семинара на создание и вывод массива случайных чисел. переделаем их под двумерный массив

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)    // for (int i = 0; i < rows; i++) == строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // for (int j = 0; i < columns; j++) == столбцы
        {
            matrix[i, j] = rnd.Next(min, max);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine();
    }

}

// создаем функцию для перборки массива, нахождение элемента у которого оба индекса четные и возведения его в квадрат
void EiemEvenIndexesToSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2) 
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
           // if (i % 2 == 0 && j % 2 == 0)
           // {
                matrix[i,j] *= matrix[i,j];
           // }
        }
    }
}

// ввод параметров 2м-массива
int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
// вывод созданного 2м-массива
PrintMatrix(array2d);

// вывод созданного 2м-массива с квадратом чисел
Console.WriteLine();
EiemEvenIndexesToSquare(array2d);
PrintMatrix(array2d);

