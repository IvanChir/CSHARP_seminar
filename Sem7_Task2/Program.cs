// Напишите программу, которая будет принимать на
// вход число и возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9


// шаблон для решения взят из факториала:

// int Factorial(int n)
// {
//     if (n == 1 || n == 0) return 1;
//     return n * Factorial(n - 1);
// }

// Console.WriteLine(Factorial(5)); // 120


int SumDigits(int num)  //123  //12 //1  //0
{
    if (num == 0) return 0;  //
    return num % 10 + SumDigits(num / 10); // 123 //12 //1 
    // 1 % 10 + 12 % 10 + 123 % 10 = 1 + 2 + 3 = 6 + 0  
}


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigits(number));





