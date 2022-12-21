int m = 2;
int[,] matrix1 = new int[m,m];
int[,] matrix2 = new int[m,m];
int[,] resultMatrix = new int[m,m];

Random rnd = new Random();

for (int i = 0; i < m; i++) {
    for (int j = 0; j < m; j ++) {
        int num = rnd.Next(1, 11);
        matrix1[j,i] = num;
    }
}

for (int i = 0; i < m; i++) {
    for (int j = 0; j < m; j ++) {
        int num = rnd.Next(1, 11);
        matrix2[j,i] = num;
    }
}

Console.WriteLine("Matrix 1:");
for (int i = 0; i < m; i++) {
    for (int j = 0; j < m; j ++) {
        Console.Write("{0} ", matrix1[j,i]);
    }
    Console.WriteLine();
}

Console.WriteLine("Matrix 2:");
for (int i = 0; i < m; i++) {
    for (int j = 0; j < m; j ++) {
        Console.Write("{0} ", matrix2[j,i]);
    }
    Console.WriteLine();
}

Console.WriteLine();

