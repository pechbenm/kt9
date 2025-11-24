using System;

public class Calculator<T> where T : new()
{
    public static T Add(T x, T y)
    {
        dynamic a = x; 
        dynamic b = y;
        return a + b;
    }

    public static T Zero()
    {
        return new T();
    }
}
class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int sum = Calculator<int>.Add(a, b);
        Console.WriteLine($"сумма: {sum}"); 

        int zero = Calculator<int>.Zero();
        Console.WriteLine($"вызов нуля: {zero}");
        Console.ReadLine();
    }
}
