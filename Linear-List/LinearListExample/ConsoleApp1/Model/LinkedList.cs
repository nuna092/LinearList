using System;
using System.Collections.Generic;
using System.Text;


public class LinkedList<T>
{
    public Item<T> Head { get; private set;}
    public Item<T> Tail { get; private set; }
    public int Count { get; private set; }

    public LinkedList()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }
    public LinkedList(T data)
    {
        SetHead(data);
    }

    public void Add(T data)
    {

        if (Tail != null)
        {
            var item = new Item<T>(data);
            Tail.Next = item;
            Tail = item;
            Count++;
        }
        else
            SetHead(data);
    }

    private void SetHead(T data)
    {
        var item = new Item<T>(data); 
        Head = item;
        Tail = item;
        Count = 1;
    }


}

