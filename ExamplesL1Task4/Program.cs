Console.Clear();
Console.WriteLine("Введите 3 числа");
int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int x3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (x1 > x2)
{max = x1;}
else
{max = x2;}
if (x3>x2) max = x3;
Console.WriteLine(max);
