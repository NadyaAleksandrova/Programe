void FillArray(int[] array)
{
    int b = array.Length - 1;
    int[] array1 = new int[8];
    for (int i = 0; i<array.Length; i++)
    {
        array[i]= new Random().Next(0,100);
        array1[b] = array[i];
        b--;
    }
    Console.WriteLine(string.Join(", ", array));
    Console.WriteLine(string.Join(", ", array1));
}

int [] array = new int[8];
FillArray(array);