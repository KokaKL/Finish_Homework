// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Promt(string msg)
{
    System.Console.Write($"{msg} -> ");
    return int.Parse(Console.ReadLine());
}

int Sum(int num1, int num2)
{
    if (num2 == num1)
    {
        return num1;
    }
    return num2 + Sum(num1, num2 - 1);
}

int m = Promt("Введите первое число");
int n = Promt("Введите второе число");
int result = Sum(m, n);
System.Console.WriteLine(result);