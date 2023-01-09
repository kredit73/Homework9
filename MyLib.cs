// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


public static class MyLib
{
    //
    public static string PrintNaturalOrders(int n)
    {
        string s = string.Empty;
        if (n >= 1)
        {
            s = n + " " + PrintNaturalOrders(n - 1);
        }

        return s;
    }

    public static int SumOfNatural(int m, int n)
    {

        if (m == n) return m;
        else return m + SumOfNatural(m + 1, n);

    }

    public static int ack(int n, int m)
    {
        if (n == 0) return m + 1;
        else if (m == 0) return ack(n - 1, 1);
        return ack(n - 1, ack(n, m - 1));

    }

}