int SumOddPos (int[] array)
{
    int Sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        Sum += array[i];
    }
    return Sum;
}

Console.Clear();
Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] Mas = new int[N];
for (int i = 0; i < Mas.Length; i++)
{
    Mas[i] = new Random().Next(-99,100);
    Console.Write(Mas[i] + " ");
}
Console.WriteLine();
int Rez = SumOddPos(Mas);
Console.WriteLine("Сумма чисел на нечетных позициях = " + Rez);