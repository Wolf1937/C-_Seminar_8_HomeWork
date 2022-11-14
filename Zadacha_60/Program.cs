// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите глубину массива: ");
int depth = Convert.ToInt32(Console.ReadLine()!);

int[,,] array = GetArray(rows, columns, depth);
Console.WriteLine();
PrintArray(array);




int[,,] GetArray(int m, int n, int z){
    int[,,] result = new int[m,n,z];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            for (int k = 0; k < z; k++){
                result[i,j,k] = new Random().Next(0,10);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] Array){
    for (int i = 0; i < Array.GetLength(0); i++){
        for (int j = 0; j < Array.GetLength(1); j++){
            for (int k = 0; k < Array.GetLength(2); k++){
                Console.WriteLine($"[{i},{j},{k}] - {Array[i, j, k]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}