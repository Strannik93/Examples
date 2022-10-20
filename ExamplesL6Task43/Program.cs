Console.Clear();
double[,] Massive = new double[2,2];
for (int i = 0; i < Massive.GetLength(0); i++)
{
    Console.WriteLine($"Ввод значении {i+1} прямой y=k{i+1}*x+b{i+1}");
    for (int j = 0; j < Massive.GetLength(1); j++)
    {
        if (j == 0) Console.Write($"Ввод k{i+1} ");
        else Console.Write($"Ввод b{i+1} ");
        Massive[i,j] = Convert.ToDouble(Console.ReadLine());
    }
}
if (Massive[0,0] == Massive[1,0] && Massive[0,1] == Massive[1,1])
    Console.WriteLine("Прямые лежат на одной прямой");
else if (Massive[0,0] == Massive[1,0]) Console.WriteLine("Прямые не пересекаются");
else 
{
    double lineX = (Massive[0,1] - Massive[1,1])/(Massive[1,0] - Massive[0,0]);
    double lineY = Massive[0,0] * lineX + Massive[0,1];
    Console.WriteLine($"Точка пересечения = ({lineX};{lineY})");
}
