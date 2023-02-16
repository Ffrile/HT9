// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//  натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());

int WriteNum(int m, int n)
{
    if (m > n)
    {
        if (n == m)
        {
            return n;
        }
        return (n + WriteNum(m, n + 1));
    }
    else
    {
        if (n == m)
        {
            return m;
        }
        return (m + WriteNum(m + 1, n));
    }
}

System.Console.WriteLine(WriteNum(m, n));