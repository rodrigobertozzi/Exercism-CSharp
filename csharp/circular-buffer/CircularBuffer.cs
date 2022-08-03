using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    private int capacity;
    private Queue<T> queue;

    public CircularBuffer(int capacity)
    {
        this.capacity = capacity;
        queue = new Queue<T>();
    }

    public T Read()
    {
        if (queue.Peek != null)
            return queue.Dequeue();
        else
            throw new InvalidOperationException();
    }
    public void Write(T value)
    {
        if (queue.Count >= capacity)
            throw new InvalidOperationException();
        else
            queue.Enqueue(value);
    }

    public void Overwrite(T value)
    {
        if (queue.Count >= capacity)
            queue.Dequeue();
        queue.Enqueue(value);
    }

    public void Clear() => queue.Clear();
}