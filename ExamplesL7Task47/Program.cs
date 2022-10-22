double[,] CreateTwoMassive (int value1, int value2)
{
    double[,] array = new double[value1,value2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double temp = new Random().Next(-100,101);
            array[i,j] = temp / 10;
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

Console.Clear();
Console.Write("ввод m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("ввод n ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] Massive = CreateTwoMassive(m,n);