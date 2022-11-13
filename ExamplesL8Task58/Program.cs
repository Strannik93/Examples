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
Console.Write("Количество строк 1 матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов 1 матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] Massive1 = new int[n,m];
FillArray(Massive1); PrintArray(Massive1);
Console.WriteLine();
Console.Write("Количество строк 2 матрицы: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов 2 матрицы: ");
int m2 = Convert.ToInt32(Console.ReadLine());
int[,] Massive2 = new int[n2,m2];
FillArray(Massive2); PrintArray(Massive2);
Console.WriteLine();
if (Massive1.GetLength(1) != Massive2.GetLength(0)) 
    Console.WriteLine("Невозможно произвести умножение матриц");
else
{
    int[,] newArray = new int[Massive1.GetLength(0),Massive2.GetLength(1)];
    int sum;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < Massive1.GetLength(1); k++)
                { sum += Massive1[i,k]*Massive2[k,j]; }
            newArray[i,j] = sum;
        }
    }
    PrintArray(newArray);
}