double FillArray(int[] array)
{
    double sum = 0;
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(-10,11);
        sum = sum + array[i];
    }
    Console.WriteLine(string.Join(", ", array));
    result = Math.Round(sum/(array.Length),2);
    return result;
}

int [] array = new int[8];
Console.WriteLine (FillArray(array));