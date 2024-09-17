// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

// создаем массив случайных чисел (возврат маасива)
int[] CreateArrayRndInt(int size, int min, int max) // функция для создания массива 
{
    int[] array = new int[size]; //  создаем массив с размероа size
    Random rnd = new Random(); // включение функции для получения случайных чисел

    for(int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max); // определили дипазон случайных чисел от min до max методом Next
    }

    return array;
}

// создаем функцию для вывода массива в консоль (невозврат массива)

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) // для вывода чисел в массиве через запятую
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        } 
    }
     Console.Write("]");
}
// создаем функцию для потсчета простых чисел
int CountPrimeNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(IsPrime(array[i]))
        {
            count++;
        }
    }

    return count;
}

// создаем функцию для проверки числа на простоту
bool IsPrime(int num)
{
    for (int i = 2; i <= Math.Sqrt(num); i++) // математически нет смысла проходить до числа num достаточно до корня из числа num Math.Sqrt(num)
    {
        if(num % i == 0) 
        {
            return false;
        }
    }
    return true;
}    


// вызов функции CreateArrayRndIn для создания массива
int[] arr = CreateArrayRndInt(10, 1, 100); // 10 = size (размер), 1 = min 100 = max

// вызов функции PrintArray для вывода сформированного массива
PrintArray(arr);

// вывод ответа 
int countPrime = CountPrimeNumbers(arr);
Console.Write($" => {countPrime}");