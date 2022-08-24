Console.WriteLine("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
 for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(-10,11);
    }
Console.WriteLine(string.Join(", ", array));
double sum = 0;
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        sum = sum + array[i];
        count++;
    }
}
Console.WriteLine($"Среднее арифметическoе положительных элементов масива равно {sum/count}");