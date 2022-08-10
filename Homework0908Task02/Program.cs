Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
string str = num.ToString();
if (str.Length > 2)
{
    Console.WriteLine(str[2]);
}
else
{
  Console.WriteLine("нет третьего числа");  
}