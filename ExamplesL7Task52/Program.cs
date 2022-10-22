int[,] CreateTwoMassive (int value1, int value2)
{
    int[,] array = new int[value1,value2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}
void ArithmeticMeanEachColumn (int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double count = 0;
        int i = 0;
        while (i < array.GetLength(0))
        {
           count += array[i,j];
           i++;
        }
        double meanAr = Math.Round((count / array.GetLength(0)), 1);
        if (j < array.GetLength(1) - 1) Console.Write(meanAr + "; ");
        else Console.WriteLine(meanAr + ".");
    }
}

Console.Clear();
Console.Write("ввод количества строк массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("ввод количества столбцов массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Massive = CreateTwoMassive(m,n);
ArithmeticMeanEachColumn(Massive);