//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] arrayNumbers()
{
    int[] array = new int[10];
    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}

void writeNumberArray(int[] array)
{
    for (int i = 0; i < 10; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Positive(int[] Myarray)
{
    int count = 0;
    for (int i = 0; i < 10; i++)
    {
        if (Myarray[i] % 2 == 0)
        {
            count= count + 1;
        }
    }
    return count;
}

int[] newArray = arrayNumbers();
writeNumberArray(newArray);
int count = Positive(newArray);
Console.WriteLine($"Количество чётных чисел в массиве: {count}");