void FillArray (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
               array[i,j,k] = UniqueValue(array,10,99,i,j,k);
            }
        }
    }
}

void PrintArray (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k})  ");
            }
        }
        Console.WriteLine();
    }
}

int UniqueValue(int[,,] array, int min, int max, int i, int j, int k)
{
    int value = default;
    bool exist = true;
    while (exist)
    {
        bool _break = false;
        value = new Random().Next(min, max + 1);
        for (int i1 = 0; i1 < array.GetLength(0); i1++)
        {
            if (_break) { break; }
            for (int j1 = 0; j1 < array.GetLength(1); j1++)
            {
                if (_break) { break; }
                for (int k1 = 0; k1 < array.GetLength(2); k1++)
                {
                    if (array[i1, j1, k1] == value) { _break = true; break; }
                    if (i1 == i && j1 == j && k1 == k) { exist = false; }
                }
            }
        }
    }
    return value;
}

Console.Clear();
int[,,] Massive = new int[2,2,2];
FillArray(Massive); PrintArray(Massive);
