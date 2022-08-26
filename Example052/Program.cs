// Задача 52:
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
Console.Clear();
Console.Write("Задайте количество строк двумерной матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов двумерной матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[] ArrayArithmeticMean = new double[columns];
double[,] ArrayRandom = new double[rows, columns];
Console.WriteLine("Полученная матрица: ");
double sum = 0;
for (int m = 0; m < rows; m++)
{
    for (int n = 0; n < columns; n++)
    {
        
        ArrayRandom[m, n] = (new Random().Next(100));
        Console.Write(ArrayRandom[m, n] + "\t");
    }
    Console.WriteLine();
}
for (int k = 0; k < columns; k++)
{
    for (int j = 0; j < rows; j++)
    {
        sum = sum + ArrayRandom[j, k];
        
    }
ArrayArithmeticMean[k] = Math.Round(sum / rows, 2);
sum = 0;
}
Console.WriteLine("Средние арифметические значения по столбцам матрицы: ");
Console.WriteLine($"{String.Join("\t", ArrayArithmeticMean)}");