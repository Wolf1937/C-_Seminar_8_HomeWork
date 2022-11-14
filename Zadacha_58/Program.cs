// Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите разменость для матриц: ");
int massSize = Convert.ToInt32(Console.ReadLine()!);
int[,] matrixA = GetArray(massSize, massSize, 0, 10);
Console.WriteLine("Матрица A: ");
PrintArray(matrixA);
int[,] matrixB = GetArray(massSize, massSize, 0, 10);
Console.WriteLine();
Console.WriteLine("Матрица B: ");
PrintArray(matrixB);
int[,] matrixC = new int[massSize, massSize];
Console.WriteLine();
Console.WriteLine("Произведение матриц A*B: ");
for (int i = 0; i < massSize; i++){
    for (int j = 0; j < massSize; j++){
        for (int k = 0; k < massSize; k++){
            matrixC[i,j] = matrixC[i,j] + (matrixA[i,k] * matrixB[k,j]);
        }
    }
}
PrintArray(matrixC);
Console.WriteLine();



int[,] GetArray(int n, int m, int minValue, int maxValue){
    int[,] result = new int[n, m];
    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] Array){
    for (int i = 0; i < Array.GetLength(0); i++){
        for (int j = 0; j < Array.GetLength(1); j++){
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}