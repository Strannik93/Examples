Console.Clear();
int[] point1 = new int[3];
Console.WriteLine("Введите x,y,z координаты 1 точки");
for (int i = 0; i < 3; i++)
{
    point1[i] = Convert.ToInt32(Console.ReadLine());
}
int[] point2 = new int[3];
Console.WriteLine("Введите x,y,z координаты 2 точки");
for (int i = 0; i < 3; i++)
{
    point2[i] = Convert.ToInt32(Console.ReadLine());
}
int Sum = 0;
for (int i = 0; i < 3; i++)
{
    if (point1[i] > point2[i]) Sum = Sum + (point1[i] - point2[i])*(point1[i] - point2[i]);
    else Sum = Sum + (point2[i] - point1[i])*(point2[i] - point1[i]);
}
double Rez = Math.Round(Math.Sqrt(Sum), 2);
Console.WriteLine(Rez);