Console.WriteLine("Введите значение: ");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int numberC = int.Parse(Console.ReadLine());
if (numberA > numberB && numberA > numberC)
{Console.WriteLine("Максимальное число " + numberA);}
else if (numberB > numberC)
{Console.WriteLine("Максимальное число " + numberB);}
else
{Console.WriteLine("Максимальное число " + numberC);}