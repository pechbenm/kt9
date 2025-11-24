using System;

public class Pair<T, U> where T : class where U : class
{
    private T _first;
    private U _second;

    public Pair(T first, U second)
    {
        _first = first;
        _second = second;
    }

    public T First
    {
        get { return _first; }
        set { _first = value; }
    }

    public U Second
    {
        get { return _second; }
        set { _second = value; }
    }

    public void Swap()
    {
        var temp = _first;
        _first = _second as T;
        _second = temp as U;
    }
}
public class Program
{
    public static void Main()
    {
        Pair<string, string> pair = new Pair<string, string>("hello", "world");

        Console.WriteLine("первое значение: " + pair.First);
        Console.WriteLine("второе значение: " + pair.Second);

        pair.Swap();

        Console.WriteLine("после обмена:");
        Console.WriteLine("первое значение: " + pair.First);
        Console.WriteLine("второе значение: " + pair.Second);
    }
}
