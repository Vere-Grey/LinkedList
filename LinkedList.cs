using System;
using System.Collections.Generic;
using System.Linq;

using Xunit.Sdk;

public class Deque<T>
{
    private readonly List<T> data = new();

    public void Push(T value) => data.Add(value);

    public T Pop()
    {
        if (!data.Any())
        {
            throw new InvalidOperationException("Sequence contains no elements");
        }

        var value = data.Last();
        data.RemoveAt(data.Count - 1);
        return value;
    }

    public void Unshift(T value) => data.Insert(0, value);

    public T Shift()
    {
        if (!data.Any())
        {
            throw new InvalidOperationException("Sequence contains no elements");
        }

        var value = data.First();
        data.RemoveAt(0);
        return value;
    }
}