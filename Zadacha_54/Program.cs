// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
Console.WriteLine("Оригинальный массив: ");
PrintArray(array);
// OrderRows(array);
for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1) - 1; j++){
        for (int z = 0; z < array.GetLength(1) - 1; z++){
            if (array[i, z] < array[i, z + 1]){
                int temp = 0;
                temp = array[i, z];
                array[i, z] = array[i, z + 1];
                array[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Построчно отсортированный массив: ");
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue,maxValue);
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