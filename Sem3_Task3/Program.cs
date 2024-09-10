// Задача 3
// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)


int[] array = { 2, 3, 1, 7, 5, 6, 3 };
int[] arrayResult = new int [array.Length/2];

int iLeft = 0; // счетчик с первого элемента
int iRiht = array.Length - 1; // счетчик с последнего элемента

while (iLeft < iRiht) 
{
    arrayResult[iLeft] = array[iLeft] * array[iRiht];
    iLeft++;
    iRiht--;
}
for(int i = 0; i < arrayResult.Length; i++)
{
    Console.Write(arrayResult[i] + ", ");
}