Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
string str = num.ToString();
if (str.Length < 4 || str.Length > 4)
{
    Console.WriteLine("Введен не верный формат числа");
    return;
}
if (str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine("полиндром");
}

else
{
    Console.WriteLine("не является полиндромом");
}