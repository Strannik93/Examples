Console.Clear();
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 0;
if (N < 1) Console.WriteLine("Введите число выше 0");
while (i < N)
{
    i++;
    Console.Write($"{i*i*i} ");
}