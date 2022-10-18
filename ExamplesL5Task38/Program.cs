int differ (int[] array)
{
    int Max = array[0];
    int Min = array[0];
    if (array[1] > Max) Max = array[1];
    else Min = array[1];
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] > Max) Max = array[i];
        else if (array[i] < Min) Min = array[i];
    }
    return Max - Min;
}

Console.Clear();
Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] Mas = new int[N];
for (int i = 0; i < Mas.Length; i++)
{
    Mas[i] = new Random().Next(1,100);
    Console.Write(Mas[i] + " ");
}
Console.WriteLine();
int Rez = differ(Mas);
Console.WriteLine("Разница между максимальным и минимальным элементам массива = " + Rez);