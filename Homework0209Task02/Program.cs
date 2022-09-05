//Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.


int M = AskNumber("M");
int N = AskNumber("N");

void NumberSum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
    NumberSum(M, N, sum);
}

int AskNumber(string name)
{
    Console.Write($"Введите число {name}: ");
    return int.Parse(Console.ReadLine());
}

NumberSum(M, N, 0);
