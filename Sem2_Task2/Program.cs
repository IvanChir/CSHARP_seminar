// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1


Console.Write("Введите целое положитоельноу трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int tooDigit = num / 10 % 10;
    int threeDigit = num % 10;
    int result = tooDigit;

    int count = 1;   // Создаем счетчик для возведения числа в степень
    while (count < threeDigit)
    {
        result = result * threeDigit; // result *= threeDigit
        count++;
    }

   Console.WriteLine(result);
}

else
{
    Console.Write("Некорректный ввод!");
}