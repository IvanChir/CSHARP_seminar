// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int CountVowls(string str)
{
    string vowels = "aeiouy"; // создаем переменную формата string. вносим в нее все гласные буквы
    int count = 0; // счетчик для подчета количества гласных
    for (int i = 0; i < str.Length; i++) // первый цикл равен длине введенного слова
    {
        for (int j = 0; j < str.Length; j++) //второй цикл для прохода в слове по гласным
        {
            if(str[i] == vowels[j]) // сравнение введенного слова с введенными гласными 
            {
                count++; // подсчет количества совпадений
            }
        }
    }
    return count;
}


Console.WriteLine("Введите слово: ");
string start = Console.ReadLine();

Console.WriteLine($"В слове {CountVowls(start)} гласных");

