int SumMN (int M, int N)
{
   if (M < 0 && N >= 0) return SumMN(0,N);
   else if (M >= 0 && N < 0) return SumMN(M,0);
   else if (M < 0 && N < 0) return SumMN(0,0);
   else if (M == N) return N;
   else if (M > N) return SumMN(N,M);
   else return N + SumMN(M,N-1);
}

Console.Clear();
Console.Write("Введите 1 целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 целое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма натуральных элементов: " + SumMN(m,N));