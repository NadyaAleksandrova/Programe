static int getnumber()
{
    int number = 0;
    do
    {
Console.WriteLine("Введите число А");
number = int.TryParse(Console.ReadLine(), out number) ? number : 0;
    } while (number <= 0);
    return number;
}

int n = getnumber();
int sum=0;
int mul=1;

for (int i= 1; i <= n; i++)
{
    sum+=i;
    mul*=i;
}
Console.WriteLine("сумма чисел:   " + sum);
Console.WriteLine("произведение чисел:   " + mul);
