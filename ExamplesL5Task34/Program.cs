int NumEvEl (int[] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) Sum++;
    }
    return Sum;
}

Console.Clear();
Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] Mas = new int[N];
for (int i = 0; i < Mas.Length; i++)
{
    Mas[i] = new Random().Next(1,1000);
    Console.Write(Mas[i] + " ");
}
int Rez = NumEvEl(Mas);
Console.WriteLine("четных чисел = " + Rez);