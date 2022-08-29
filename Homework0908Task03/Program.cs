Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine("Введен не верный формат дня недели");
}
if (number >= 6 && number <= 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Нет");
}
