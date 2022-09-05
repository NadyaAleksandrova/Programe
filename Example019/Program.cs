/*
Написать программу, которая на вход получает массив данных от пользователя через запятую и на выходе выдаёт массив состоящий из четных чисел
пример:
1,2,3,4,5,6,7,8 => 2 4 6 8
*/

// int[] array = Console.ReadLine().Split(",")
//                                             .Select(num => int.Parse(num))
//                                             .Where(n => n % 2 == 0)
//                                             .ToArray();
// Console.WriteLine(string.Join(" ", array));

int[] Array(int[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            size ++;
        }
    }
    int[] even = new int[size];
    size = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0)
        {
            even[size] = array[j];
            size++;
        }
    }
    return even;
}

void ArrayOtput(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    Console.Write($" {array[j]} ");
}

int[] NumsArray (string[] array)
{
    int[] arrayNums = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    arrayNums[i] = int.Parse(array[i]);
    return arrayNums;
}

string[] StrSplit (string str)
{
    int size = 0;
    foreach(char c in str)
    {if(c == char.Parse(",")) size++;}
    size++;

    string[] numsStr = new string[size];
    string num = "";
    size = 0;
    for(int i = 0; i < str.Length; i++)
    {
        if(str[i] == char.Parse(","))
        {
            numsStr[size] = num;
            size++;
            num = "";
        } 
        else
        num += str[i].ToString();
    }
    numsStr[size] = num;
    return numsStr;
}

Console.WriteLine("Введите числа через запятую без пробелов");
ArrayOtput(Array(NumsArray(StrSplit(Console.ReadLine()))));
Console.WriteLine();