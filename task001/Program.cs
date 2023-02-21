// Задайте значения M и N. Напишите программу, которая выведет все 
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Promt(string msg)
{
    System.Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

void Chet(int num1, int num2)
{
    if (num2 <= 1) 
    {
        System.Console.WriteLine("Второе число должно быть больше 0 и не равняться единице"); 
        Environment.Exit(1);
    }
    
    if (num1 % 2 == 1) num1++;
    if (num1 > num2) return;
    System.Console.Write(num1 + "; ");
    Chet(num1 + 2, num2);
}

int m = Promt("Введите первое число");
int n = Promt("Введите второе число");
Chet(m,n);