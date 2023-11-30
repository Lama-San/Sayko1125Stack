using System;
public class StackItem<DontKnow>
{
    public StackItem<DontKnow> Previous { get; set; }
    public DontKnow Value { get; set; }
}

public class MyStack<DontKnow>
{
    private StackItem<DontKnow> top;

    public void Push(DontKnow value)
    {
        var newItem = new StackItem<DontKnow>()
        {
            Value = value,
            Previous = top
        };
        top = newItem;
    }

    public DontKnow Pop()
    {
        if (top == null)
        {
            return default(DontKnow);
        }

        var value = top.Value;
        top = top.Previous;
        return value;
    }

    public DontKnow Peek()
    {
        if(top != null)
            return top.Value;
        return default(DontKnow);
    }

    public int Count
    {
        get
        {
            int count = 0;
            var current = top;
            while (current != null)
            {
                count++;
                current = current.Previous;
            }
            return count;
        }
    }

    public void Clear()
    {
        top = null;
    }
}

