// Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки 
//двумерного массива.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//двумерный массив с случайным вводом (универсальный)
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)  //или rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)    //или columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

//вывод массива на экран (универсальный)
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)  //или rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)    //или columns
        {
            Console.Write($"{matrix[i, j],5}");  //5 это чтобы разделять числа
        }
        Console.WriteLine();
    }
}

//метод сортировки двумерного массива по убыванию
void SelectionSortMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i,maxPosition]) maxPosition = k;  //меняем местами элементы массива
            }
            int temp = matrix[i, j];   //обмен двух переменных местами
            matrix[i, j] = matrix[i,maxPosition];   //обмен двух переменных местами
            matrix[i,maxPosition] = temp;  //обмен двух переменных местами
        }
    }
}


int[,] array2d = CreateMatrixRndInt(4, 5, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();

SelectionSortMatrix(array2d);
PrintMatrix(array2d);
