void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }

    }
    return;
}

void AverageArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int count = 0;
            double sum = 0;
            while (count < array.GetLength(0))
            {
                sum = sum + array[count, j];
                count++;
            }
            Console.WriteLine($"Среднее арифметическое колонки {j + 1} = {sum / count}; ");
        }
        return;
    }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return;
}

Console.WriteLine("Введите количество строк и столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
AverageArray(array);
