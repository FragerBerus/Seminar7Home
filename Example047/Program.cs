// Задача 47.
// Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
Console.Write("Задайте количество строк двумерного массива: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов двумерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] ArrayRandom = new double[lines, columns];
for (int m = 0; m < lines; m++)
{
    for (int n = 0; n < columns; n++)
    {
        double temp = (new Random().Next(-10000, 10000));
        ArrayRandom[m, n] = temp / 100;
        Console.Write(ArrayRandom[m, n] + "\t");
    }
    Console.WriteLine();
}