int[] arrayNumbers10()
{
    int[] array = new int[10];
    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void writeNumberArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SumNegPos(int[] array)
{
    int Neg = 0;
    int Pos = 0;
    for (int i = 0; i < 10; i++)
    {
        if (array[i] < 0) { Neg += array[i]; }
        else { Pos += array[i]; }
    }
    Console.WriteLine($"Сумма положительных чисел равна {Pos}, сумма отрицательных чисел равна {Neg}.");
}

int[] newArray = arrayNumbers10();
writeNumberArray(newArray);
SumNegPos(newArray);