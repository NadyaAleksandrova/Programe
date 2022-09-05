int M = AskNumber("M");
int N = AskNumber("N");
Console.WriteLine($"{PrintNumber(M, N)}");

string PrintNumber(int M, int N)
{
    if (M < N || M <= 0 || N <= 0) return "";
    if (M == N) return N.ToString();
    else return "" + M.ToString() + ", " + PrintNumber(++M, N);

}

int AskNumber(string name)
{
    Console.Write($"Введите число {name}: ");
    return int.Parse(Console.ReadLine());
}
