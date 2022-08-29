Console.WriteLine("Введите числа ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine ("Первое число больше, второе число меньше");
}
else
{
    Console.WriteLine ("Второе число больше, первое число меньше");
}