using System;
using System.Collections.Generic;

public class Stack<T> where T : IComparable<T>
{
    private List<T> _elements = new List<T>();

    public void Push(T item)
    {
        _elements.Add(item);
    }

    public T Pop()
    {
        if (_elements.Count == 0)
            throw new InvalidOperationException("стек пуст");

        T topItem = _elements[_elements.Count - 1];
        _elements.RemoveAt(_elements.Count - 1);
        return topItem;
    }

    public T Peek()
    {
        if (_elements.Count == 0)
            throw new InvalidOperationException("стек пуст");

        return _elements[_elements.Count - 1];
    }

    public bool IsEmpty()
    {
        return _elements.Count == 0;
    }

    public T Max()
    {
        if (_elements.Count == 0)
            throw new InvalidOperationException("стек пуст");

        T maxItem = _elements[0];

        foreach (var item in _elements)
        {
            if (item.CompareTo(maxItem) > 0)
            {
                maxItem = item;
            }
        }

        return maxItem;
    }
}
public class Program
{
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(5);

        Console.WriteLine("максимальный элемент: " + stack.Max()); 

        Console.WriteLine("удаление верхнего элемента: " + stack.Pop()); 
        Console.WriteLine("новый максимальный элемент: " + stack.Max()); 
    }
}

