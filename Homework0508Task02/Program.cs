Console.WriteLine("Введите значение: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB && numberA > numberC)
{Console.WriteLine("Максимальное число " + numberA);}
else if (numberB > numberC)
{Console.WriteLine("Максимальное число " + numberB);}
else
{Console.WriteLine("Максимальное число " + numberC);}