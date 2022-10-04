Console.Clear();
Console.WriteLine("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine());

if (x % 2 == 0) Console.WriteLine("число четное");
else
{
    Console.WriteLine("число не является четным");
}