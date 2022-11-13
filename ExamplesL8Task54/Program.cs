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

void RowArraySort (int[,] array)
{
    int count; int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        count = array.GetLength(1) - 1;
        while (count > 0)
        {
            for (int j = 0; j < count; j++)
            {
                if (array[i,j] < array[i,j+1])
                { temp = array[i,j]; array[i,j] = array[i,j+1]; array[i,j+1] = temp; }
            }
            count--;
        }
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
RowArraySort(Massive); PrintArray(Massive);