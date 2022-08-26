// Задача 50:
// Напишите программу, которая на вход принимает позиции элемента в
// двумерном массиве, и возвращает значение этого элемента или же
// указание, что такого элемента нет.
Console.Clear();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] ArrayRandom = new int[rows, columns];
for (int m = 0; m < rows; m++)
{
    for (int n = 0; n < columns; n++)
    {
        ArrayRandom[m, n] = (new Random().Next(100));
        Console.Write(ArrayRandom[m, n] + "\t");
    }
    Console.WriteLine();
}
Console.Write("Введите номер строки: ");
int gorizontal = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите номер столбца: ");
int vertical = Convert.ToInt32(Console.ReadLine()) - 1;
if (gorizontal > rows || vertical > columns || gorizontal < 0 || vertical < 0)
{
    Console.WriteLine("Такого элемента не существует.");
}
else
{
    Console.Write($"Элемент с индексами [{gorizontal} ,{vertical}] равен {ArrayRandom[gorizontal, vertical]}.");
}