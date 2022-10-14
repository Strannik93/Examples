Console.Clear();
Console.WriteLine("Введите пятизначное число");
int X = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToString(X).Length;
if (N != 5 || X < 0) Console.WriteLine("Число не пятизначное или меньше 0");
else
{
    String XK = Convert.ToString(X);
    int j = N - 1;
    for (int i = 0; i < j; i++)
    {
        if (XK[i] != XK[j])
        {
            Console.WriteLine("пятизначное число не является палиндромом");
            return;
        }
        j = j - 1;
    }
    Console.WriteLine("пятизначное число является палиндромом");
}