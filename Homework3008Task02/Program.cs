Console.WriteLine("Введите количество строк и столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

int[] sumArray = SumArray(array);
int numOfRow = FindIndexOfMin(sumArray);
Console.WriteLine($"номер строки с наименьшей суммой элементов: {numOfRow + 1} строка");

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

int FindIndexOfMin(int[] array)
{
    int indexOfMin = 0;
    int min = array[indexOfMin];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            indexOfMin = i;
        }
    }
    return indexOfMin;

}

int[] SumArray(int[,] array)
{
    int[] SumArray = new int[array.GetLength(0)];

    for (int row = 0; row < array.GetLength(0); row++)
    {
        int sum = 0;
        for (int column = 0; column < array.GetLength(1); column++)
        {
            sum += array[row, column];
        }
        SumArray[row] = sum;
    }

    return SumArray;
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


