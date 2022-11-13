void RowSmallestSumElements (int[,] array)
{
    int sum; int minRow = 0; int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if (sum < minSum || i == 0) {minSum = sum; minRow = i; }
    }
    Console.WriteLine($"В {minRow + 1} строке найменьшая сумма элементов({minSum})");
}

void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }

}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] Massive = new int[n,m];
FillArray(Massive); PrintArray(Massive);
Console.WriteLine();
RowSmallestSumElements(Massive);