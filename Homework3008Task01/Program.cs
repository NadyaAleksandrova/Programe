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

void SortArray(int[,] array) {
    for(int row = 0; row < array.GetLength(0); row++) {
        bool needSort = true;
        while(needSort) {
            needSort = false;
            for(int column = 0; column < array.GetLength(1) - 1; column++) {
                int v1 = array[row, column];
                int v2 = array[row, column + 1];
                if(v1 < v2) {
                    array[row, column] = v2;
                    array[row, column + 1] = v1;
                    needSort = true;
                }
            }
        }
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
SortArray(array);
Console.WriteLine();
PrintArray(array);
