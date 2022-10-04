Console.Clear();
Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
int temp = 0;

if (N < 2) Console.WriteLine("Введите число 2 и более");
while (temp < N)
{
    temp++;
    if (temp % 2 == 0) Console.Write($"{temp} ");
}