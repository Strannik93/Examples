int[,] CreateTwoMassive (int value1, int value2)
{
    int[,] array = new int[value1,value2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}
string ElementSearch (int[,] array, int Positioni, int Positionj)
{
    if (array.GetLength(0) < Positioni || array.GetLength(1) < Positionj)
        return "Такого элемента нет";
    else if (Positioni < 0 || Positionj < 0) return "Позиции могут быть только > 0";
    else return $"{array[Positioni-1,Positionj-1]}";
}

Console.Clear();
Console.Write("ввод количества строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("ввод количества столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Massive = CreateTwoMassive(m,n);
Console.Write("ввод искомой строки ");
int ich = Convert.ToInt32(Console.ReadLine());
Console.Write("ввод искомого столбца ");
int jch = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Искомый элемент: " + ElementSearch(Massive,ich,jch));
