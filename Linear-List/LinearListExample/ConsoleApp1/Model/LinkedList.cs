using System;

public class LinkedList<T>
{
    public Item<T> Head { get; private set;}
    public Item<T> Tail { get; private set; }
    public int Count { get; private set; }

    public LinkedList()
    {
        Initialize();
    }
    public LinkedList(T data)
    {
        Initialize();
        Add(data);
    }

    public void Add(T data)
    {
        if (Tail == null)
        {
            SetTail(SetHead(data));
            return;
        }
        CreatNewItem(data);
    }

    public void Delete(Item<T> data)
    {
        if (Head == null)
            return;
        if (data.Equals(Head))
        {
            Head = data.Next;
            Count--;
            return;
        }

        var previous = Head;
        var current = Head.Next;

        while (current != null)
        {
            if (current.Data.Equals(data))
            {               
                previous.Next = current.Next;
                Count--;
                return;
            }
            previous = current;
            current = current.Next;
        }

    }

    private void Initialize()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    private void CreatNewItem(T data)
    {
        var item = new Item<T>(data);
        Tail.Next = item;
        SetTail(item);
        Count++;
    }

    private Item<T> SetHead(T data)
    {
        var item = new Item<T>(data); 
        Head = item;
        Count = 1;
        return item;
    }

    private void SetTail(Item<T> item)
    {
        Tail = item;
    }




}

