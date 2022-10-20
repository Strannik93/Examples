Console.Clear();
Console.Write("Введите количество чисел ");
int M = Convert.ToInt32(Console.ReadLine());
int[] Massive = new int[M];
int count = 0;
for (int i = 0; i < Massive.Length; i++)
{
    Massive[i] = Convert.ToInt32(Console.ReadLine());
    if (Massive[i] > 0) count++;
}
Console.WriteLine("Чисел больше 0 = " + count);
