void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
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

int Sum(int[,] matr)
{
    int Sumelement = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j)
            {
                Sumelement = Sumelement + matr[i, j];
            }
        }
    }
    return Sumelement;
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
int Sumelement = Sum(matrix);
Console.WriteLine($"Сумма элеметов по диагонали: {Sumelement}");
