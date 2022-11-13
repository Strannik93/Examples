void FillSpiral (int[,] array)
{
    int imin = 0; int imax = array.GetLength(0) - 1;
    int jmin = 0; int jmax = array.GetLength(1) - 1;
    int count = 1;int step = 1;
    while (imin <= imax && jmin <= jmax)
    {
        if (step == 1)
        {
            for (int i = jmin; i <= jmax; i++) {array[imin,i] = count; count++; }
            step = 2; imin++;
        }
        else if (step == 2)
        {
            for (int i = imin; i <= imax; i++) {array[i,jmax] = count; count++; }
            step = 3; jmax--;
        }
        else if (step == 3)
        {
            for (int i = jmax; i >= jmin; i--) {array[imax,i] = count; count++; }
            step = 4; imax--;
        }
        else if (step == 4)
        {
            for (int i = imax; i >= imin; i--) {array[i,jmin] = count; count++; }
            step = 1; jmin++;
        }
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10) Console.Write("0" + array[i,j] + " ");
            else Console.Write(array[i,j] + " ");
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
FillSpiral(Massive);
PrintArray(Massive);