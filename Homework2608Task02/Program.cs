Console.WriteLine("Введите количество строк и столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }

    }
    return;
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



bool SearchArray(int[,] аrray)
{
    Console.WriteLine("Введите число: ");
    int k = Convert.ToInt32(Console.ReadLine());
    int rowIndex = -1;
    int colsIndex = -1;
    for (int i = 0; i < аrray.GetLength(0); i++)
    {
        for (int j = 0; j < аrray.GetLength(1); j++)
        {
            if (аrray[i, j] == k)
            {
                rowIndex = i;
                colsIndex = j;
                Console.WriteLine($"Число найдено: {rowIndex},{colsIndex}");
                return true;
            }
        }

    }
    Console.WriteLine("Число не найдено");
    return false;
}


Console.WriteLine();
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
SearchArray(array);
