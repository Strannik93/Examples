Console.Clear();
Console.WriteLine("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine());
int N = x.ToString().Length;
int Nrez = N - 2;
int temp = 0;
int x1 = 0;
if (x < 0) {Console.WriteLine("число меньше 0");}
else
{
    if (N < 3)
    {Console.WriteLine("третьей цифры нет");}
    else
    {
        while (N > Nrez)
        {
            N = N - 1;
            temp = Convert.ToInt32(Math.Pow(10, N));
            x1 = x % temp;
        }
        N = N - 1;
        temp = Convert.ToInt32(Math.Pow(10, N));
        int rez = x1 / temp;
        Console.WriteLine(rez);
    }
}
