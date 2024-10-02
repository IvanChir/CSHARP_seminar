// Считать строку с консоли, содержащую латинские
// буквы. Вывести на экран согласные буквы этой
// строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

// создаем метод через рекурсию 

void PrintConsonans(string str, int index = 0)
{
    if (index == str.Length)
    {
        return;
    }
    CheckPrintConsonans(str, index);

    PrintConsonans(str, index + 1);
}

// метод для проверки на отсутствие гласных букв
void CheckPrintConsonans(string str, int index)
{
    string vowels = "aeiouy";

    if (char.IsAsciiLetter(str[index]) & !vowels.Contains(str[index])) // если вводимая строка является буквой и не содержит гласные буквы
    {
        Console.Write($"{str[index]} ");
    }
}

Console.WriteLine("Введите строку содержащую латинские буквы: ");
string text = Console.ReadLine();

PrintConsonans(text);

