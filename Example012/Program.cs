int[] arrayNumbers10()
{
    int[] array = new int[10];
    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

int[] change(int[] array)
{
    for (int i = 0; i < 10; i++)
    {
        array[i] *= -1;
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

int[] newArray = arrayNumbers10();
writeNumberArray(newArray);
newArray = change(newArray);
writeNumberArray(newArray);