void ZapMas (int []Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"Введите {i+1} элемент массива ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void Ex (int []Array)
{
    if (Array.Length > 3) 
    {
        Console.Write("[");
        for (int i = 0; i < Array.Length - 3; i++)
        {
            if (i != Array.Length - 4) Console.Write($"{Array[i]},");
            else Console.Write($"{Array[i]}]");
        }
        Console.WriteLine();
        Console.Write("[");
        for (int i = Array.Length - 3; i < Array.Length; i++)
        {
            if (i != Array.Length - 1) Console.Write($"{Array[i]},");
            else Console.Write($"{Array[i]}]");
        }
    }
    else
    {
       Console.Write("[");
        for (int i = 0; i < Array.Length; i++)
        {
            if (i != Array.Length - 1) Console.Write($"{Array[i]},");
            else Console.Write($"{Array[i]}]");
        } 
    }
}

Console.Clear();
int[] Mas = new int[8];
ZapMas(Mas);
Ex(Mas);