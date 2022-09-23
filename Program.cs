int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(0, 10);
        }
    }
    return mas;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
        }
    }
}
void Swap(ref int leftItem, ref int rightItem)
{
    int temp = leftItem;

    leftItem = rightItem;

    rightItem = temp;
}
//----------------------------------Exercise #54------------------------------
/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
//----------------------------------SOLUTION-----------------------------------

int[,] SortDownLine(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++) // Берем строку
    {
        for (int j = 0; j < mas.GetLength(1); j++)  // Перебираем ячейки в строке
        {
            for (int k = 0; k < mas.GetLength(1); k++)  // Перебираем сравниваемые элементы
            {
                if (mas[i, j] > mas[i, k]) Swap(ref mas[i, j], ref mas[i, k]); // Метод сортировки пузырьковый, но работает и надежный
            }
        }
    }
    return mas;
}

int[,] newarry = FillMas(3, 5);
PrintArray(newarry);
System.Console.WriteLine("____________");
PrintArray(SortDownLine(newarry));
