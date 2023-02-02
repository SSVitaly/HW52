void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 11);
        }
    }
}

Console.WriteLine("Задайте число строк в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число столбцов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
double[] result = new double[n];
Console.WriteLine("Создадим массив целых чисел в диапазоне от -10 до 10:");
FillArray(array);
PrintArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result[j] += array[i, j];
    }
    result[j] = result[j] / (m);
    Console.WriteLine($"Средняя арифметическая элементов в столбце {j} = {result[j]:f2}");
}
