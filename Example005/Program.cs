Console.WriteLine("Введите ваше имя: ");
string username = Console.ReadLine()!;
if (username.ToLower() == "маша")
{
    Console.WriteLine("Я так тебя ждала, Маша!");
}
else
{
Console.Write("Привет, ");
Console.WriteLine(username);
}