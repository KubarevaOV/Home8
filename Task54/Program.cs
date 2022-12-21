/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

for (int i = 0; i < n; i++) {
    int [] lineArray = new int [m];

    for (int j = 0; j < m; j++) {
        lineArray[j] = array[j,i];
    }

    Array.Sort(lineArray);
    Array.Reverse(lineArray);

    for (int k = 0; k < m; k++) {
        array[k,i] = lineArray[k];
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