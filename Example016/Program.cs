int[] FillArray(int capacity)
{
    int[] array = new int[capacity];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
        Console.Write(array[i] + " ");
    }
    return array;
}

void arrayReverse(int[] array)
{
    int size = array.Length;
    for(int i = 0; i < size / 2; i++)
    {
        int temp = array[i];
        array[i] = array[size - i - 1];
        array[size - i - 1] = temp;
    }
}

int[] arr = FillArray(10);
Console.WriteLine();
arrayReverse(arr);

Console.WriteLine(string.Join(", ", arr));