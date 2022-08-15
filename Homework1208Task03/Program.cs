// Принимает на вход число N и выдает таблицу кубов от 1 до N
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.WriteLine("{0}^3 = {1}", i, i * i * i);

