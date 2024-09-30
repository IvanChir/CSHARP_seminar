// 1. Задайте массив символов (тип char []). 
// 2. Создайте строку из символов этого массива.


// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”



// создание функции для создания массива из символов строки

string CharArrayToString(char[] arr)
{
    string res = string.Empty; // string res = "";
    for (int i = 0; i < arr.Length; i++)
    {
        res += arr[i];
    }
    return res;
}

// задается строка с символами

char[] array = { 'a', 'b', 'c', 'd', 'e' };

// вывод результата

string result = CharArrayToString(array);
Console.WriteLine(result);