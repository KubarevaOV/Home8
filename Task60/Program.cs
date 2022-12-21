/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int [] allSymbols = new int[8];
int counter = 0;

int m = 2;
int[,,] matrix1 = new int[m,m,m];
Random rnd = new Random();

for (int x = 0; x < m; x++) {
    for (int y = 0; y < m; y++) {
        for (int z = 0; z < m; z++) {
            var num = 0;
            do {
                num = rnd.Next(10, 100);
                Console.WriteLine("Цифра {0}", num);
            } while (allSymbols.Contains(num) == true);
            Console.WriteLine("Добавили {0}", num);
            allSymbols[counter] = num;
            counter++;
            matrix1[z,y,x] = num;
        }
    }
}

for (int x = 0; x < m; x++) {
    for (int y = 0; y < m; y++) {
        for (int z = 0; z < m; z++) {
            Console.Write("{0}({1},{2},{3}) ", matrix1[x, y, z], x, y, z);
        }
        Console.WriteLine();
    }
}