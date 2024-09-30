// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]



Console.WriteLine("Введите строку: ");
string str = Console.ReadLine();

char[] StringToArray(string s)
{
    char[] strArr = new char[s.Length];

    for (int i = 0; i < s.Length; i++)
    {
        strArr[i] = s[i];
    }
    return strArr;
}

void PrintArray(char[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        Console.Write($"{array[i]}, ");
        else
        Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

char[] resArray = StringToArray(str);
PrintArray(resArray);