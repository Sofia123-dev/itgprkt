// Задача 64
// Console.WriteLine("Введите натуральное число больше 1:");
// int num = Convert.ToInt32(Console.ReadLine());

// void NumberCounter (int num)
// {
//     if (num < 0) Console.Write($"{num} не натуральное число");
//     if (num == 0) return;
//     Console.Write("{0,4}", num);
//     NumberCounter (num - 1);
// }

// NumberCounter(num);

// Задача 66
// int SumNum(int m, int n)
// {
//     if (m == n) return n;
//     return m + SumNum(m + 1, n);
// }
// Console.Write("Введите первое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumNum(number, number1));

// Задача 68

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m > 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));

}
Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"m = {number}, n = {number1} -> A(m,n) = {Akkerman(number, number1)}");
