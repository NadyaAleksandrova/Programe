// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] arrayNumbers()
{
    int[] array = new int[10];
    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(0, 50);
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

int Sum(int[] Myarray)
{
    int Sumelement = 0;
    for (int i = 0; i < Myarray.Length; i++)
    {
        if (i %2 != 0)
        {
            Sumelement = Sumelement + Myarray[i];
        }
    }
    return Sumelement;
}

int[] newArray = arrayNumbers();
writeNumberArray(newArray);
int Sumelement = Sum(newArray);
Console.WriteLine($"Сумма нечетных элеметов массива: {Sumelement}");