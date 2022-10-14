int Step(int M, int N)
{
    int Pr = 1;
    if (N > 0)
    {
        for (int i = 1; i <= N; i++)    
        {
            Pr = Pr * M;
        }
    }
    else if (N < 0) Pr = 0;
    return Pr;
}

Console.Clear();
Console.WriteLine("Введите число, которое надо возвести в нужную степень");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int St = Convert.ToInt32(Console.ReadLine());
int Rez = Step(X, St);
Console.WriteLine(Rez);