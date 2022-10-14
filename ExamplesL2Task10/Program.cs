Console.Clear();
Console.WriteLine("Введите целое трехзначное число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(x % 100 / 10);