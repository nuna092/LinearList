using System.Collections;

public class LinkedList<T>: IEnumerable
{
    public Item<T> Head { get; private set;}
    public Item<T> Tail { get; private set; }
    public int Count { get; private set; }
    public LinkedList()
    {
        ClearList();
    }
    public LinkedList(T data)
    {
        ClearList();
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

    public void Delete(T data)
    {
        if (Head == null)
            return;
        if (Head.Data.Equals(data))
        {
            Head = Head.Next;
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

    public void Clear()
    {
        ClearList();
    }

    public void InsertAfter(T target, T data)
    {
        if(Head == null)
        {
            CreatNewItem(data);
            return;
        }
       
        if (Head.Data.Equals(target))
        {
            CreateItemAndIsert(Head, data);
            return;
        }
       
        var current = Head.Next;

        while (current != null)
        {           
            if (current.Data.Equals(target))
            {
                CreateItemAndIsert(current, data);
                return;
            }        
            current = current.Next;
        }
    }

    private void CreateItemAndIsert(Item<T> previousItem, T data)
    {
        var item = new Item<T>(data);
        item.Next = previousItem.Next;
        previousItem.Next = item;
        Count++;
    }

    private void ClearList()
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

    public IEnumerator GetEnumerator()
    {
        var current = Head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }


}

