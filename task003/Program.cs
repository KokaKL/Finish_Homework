// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Promt(string msg)
{
    System.Console.Write($"{msg} -> ");
    return int.Parse(Console.ReadLine());
}

int AckermanFun(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    if (n == 0)
    {
        return AckermanFun(m - 1, 1);
    }
    else
    {
        return AckermanFun(m - 1, AckermanFun(m, n - 1));
    }
}

int m = Promt("Введите первое число");
int n = Promt("Введите второе число");
int result = AckermanFun(m, n);
System.Console.WriteLine(result);