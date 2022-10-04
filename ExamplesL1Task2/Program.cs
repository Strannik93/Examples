Console.Clear();
Console.WriteLine("Введите 2 числа");
int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
if(x1 > x2)
{Console.WriteLine($"{x1} максимальное, {x2} минимальное");}
else
{Console.WriteLine($"{x2} максимальное, {x1} минимальное");}

