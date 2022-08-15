// Программа, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве


double Decision(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
{
    double d = Math.Sqrt(Math.Pow((x1 - x2), 2) +
                         Math.Pow((y1 - y2), 2) +
                         Math.Pow((z1 - z2), 2));
    return d;
}

Console.WriteLine("Введите координату Х точки 1:  ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки 1:  ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z точки 1:  ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X точки 2:  ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y точки 2:  ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z точки 2:  ");
int z2 = int.Parse(Console.ReadLine());
double result = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Расстояние между точками {result}");