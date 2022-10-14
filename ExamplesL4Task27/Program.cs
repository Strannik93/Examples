int SumNum(int N)
{
    int Sum = 0;
    for (int i = 0; i < Convert.ToString(N).Length; i++)
    {
        Sum = Sum + Convert.ToString(N)[i] - 48;
    }
    return Sum;
}

Console.Clear();
Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
int Rez = SumNum(Number);
Console.WriteLine(Rez);