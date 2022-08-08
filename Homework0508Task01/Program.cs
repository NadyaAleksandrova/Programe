Console.WriteLine("Введите числа ");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine ("Первое число больше, второе число меньше");
}
else
{
    Console.WriteLine ("Второе число больше, первое число меньше");
}