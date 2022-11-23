int AckermFunction (int M, int N)
{
   if (M == 0) return N + 1;
   else if (M > 0 && N == 0) return AckermFunction(M-1,1);
   else return AckermFunction(M - 1, AckermFunction(M, N - 1));
}

Console.Clear();
Console.Write("Введите 1 целое неотрицательное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 целое неотрицательное число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (N >= 0 && m >= 0) 
    Console.WriteLine("Результатом функции Аккермана явяляется: " + AckermFunction(N,m));
else Console.WriteLine("Не все числа являются неотрицательными");