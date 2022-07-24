/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа n и m.
n = 2, m = 3 -> A(n,m) = 29*/

int n = 2;
int m = 3;

int FunAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if ((m != 0) && (n == 0)) return FunAkkerman(m - 1, 1);
    return FunAkkerman(m - 1, FunAkkerman(m, n - 1));
}

Console.WriteLine(FunAkkerman(m, n));