// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AccFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AccFunc(m - 1, 1);
    }
    else return (AccFunc(m - 1, AccFunc(m, n - 1)));
}
System.Console.WriteLine(AccFunc(3,2));