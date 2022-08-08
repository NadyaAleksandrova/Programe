Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int count = 2;
while (count < N)
{
    Console.WriteLine ("  " +count);
    count = count + 2;
}
