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
        if (Tail == null)
        {
            SetTail(SetHead(data));
            return;
        }
        CreatNewItem(data);
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

