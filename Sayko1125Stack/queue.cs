
var queue = new Queue<int>();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);

Console.WriteLine(queue.Dequeue()); // Извлечет и выведет 1
Console.WriteLine(queue.Dequeue()); // Извлечет и выведет 2
Console.WriteLine(queue.Dequeue()); // Извлечет и выведет 3
Console.WriteLine(queue.Dequeue()); // Извлечет и выведет 4
Console.WriteLine(queue.Peek()); // Выбросит исключение, так как очередь пустая

public class QueueItem<DontKnow>
{
    public DontKnow Value { get; set; }
    public QueueItem<DontKnow> Next { get; set; }

    public QueueItem(DontKnow value)
    {
        Value = value;
        Next = null;
    }
}

public class Queue<DontKnow>
{
    private QueueItem<DontKnow> first;
    private QueueItem<DontKnow> last;

    public Queue()
    {
        first = null;
        last = null;
    }

    public void Enqueue(DontKnow value)
    {
        var newItem = new QueueItem<DontKnow>(value);

        if (last == null)
        {
            first = newItem;
            last = newItem;
        }
        else
        {
            last.Next = newItem;
            last = newItem;
        }
    }

    public DontKnow Dequeue()
    {
        if (first == null)
        {
             Console.WriteLine("Очередь пуста");
        }

        var value = first.Value;
        first = first.Next;

        if (first == null)
        {
            last = null;
        }

        return value;
    }

    public DontKnow Peek()
    {
        if (first == null)
        {
            Console.WriteLine("Очередь пуста");
        }
        if (first != null)
        {
            return default(DontKnow);
        }
            
      
        return first;
    }

}


