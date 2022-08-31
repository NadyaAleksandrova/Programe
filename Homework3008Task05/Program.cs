Console.WriteLine("Введите количество строк и столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[m, n];

int value = 1;
for(int column = 0; column < array.GetLength(1); column++) {
    array[0,column] = value;
    value++;
}

for(int row = 1; row < array.GetLength(0); row++) {
    array[row, array.GetLength(1) - 1] = value;
    value++;
}

for(int column = array.GetLength(1) - 2; column >= 0; column--) {
    array[array.GetLength(0) - 1, column] = value;
    value++;
}

for(int row = array.GetLength(0) - 2; row >= 1; row--) {
    array[row, 0] = value;
    value++;
}

int cRow = 1;
int cColumn = 1;

while (value < array.GetLength(0) * array.GetLength(1)) {
    while(array[cRow, cColumn + 1] == 0) {
        array[cRow, cColumn] = value;
        value++;
        cColumn++;
    }
    while(array[cRow + 1, cColumn] == 0) {
        array[cRow, cColumn] = value;
        value++;
        cRow++;
    }
    while(array[cRow, cColumn - 1] == 0) {
        array[cRow, cColumn] = value;
        value++;
        cColumn--;
    }
    while(array[cRow - 1, cColumn] == 0) {
        array[cRow, cColumn] = value;
        value++;
        cRow--;
    }
}

for (int row = 0; row < array.GetLength(0); row++) {
    for (int column = 0; column < array.GetLength(1); column++) {
        if (array[row, column] == 0) {
            array[row, column] = value;
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return;
}

PrintArray(array);