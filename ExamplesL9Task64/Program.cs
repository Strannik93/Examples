void PrintN (int N)
{
    if (N == 1) Console.WriteLine(N);
    else if (N > 1)
    {
        Console.Write(N + ", ");
        PrintN(N-1);
    }
    else
    {
        Console.Write($"{N*-1}, ");
        PrintN((N+1)*-1);
    }
}

Console.Clear();
Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintN(N);