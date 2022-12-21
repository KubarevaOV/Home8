/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int m = 3;
int n = 4;
int[,] array = new int[m,n];
Random rnd = new Random();

for (int i = 0; i < n; i++) {
    for (int j = 0; j < m; j ++) {
        int num = rnd.Next(1, 11);
        array[j,i] = num;
    }
}

for (int i = 0; i < n; i++) {
    Console.Write("[");
    for (int j = 0; j < m; j ++) {
        Console.Write("{0}, ", array[j,i]);
    }
    Console.WriteLine("]");
}
Console.WriteLine();

var sum = 0;
var minSum = 9999999;
var minElementIndex = 0;
for (int i = 0; i < n; i++) {
    for (int j = 0; j < m; j++) {
        sum = sum + array[j,i];
    }
    if (sum < minSum) {
        minSum = sum;
        minElementIndex = i;
        sum = 0;
    }
}

Console.WriteLine("Строка с меньшей суммой элементов под номером {0}", minElementIndex);