using System;

public static class FibonacciOperations
{
    public static bool isPerfectSquare(int x)
    {
        int s = sqrt(x);
        return (s * s == x);
    }

    public static bool isFibonacci(int n)
    {
        return isPerfectSquare(5 * n * n + 4) ||
               isPerfectSquare(5 * n * n - 4);
    }

}
