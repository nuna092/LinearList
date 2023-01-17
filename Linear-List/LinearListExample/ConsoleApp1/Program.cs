using System;

namespace LinearListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            NodeList nodeList = new NodeList();
            nodeList.AddLast("1");
            nodeList.AddLast("2");
            nodeList.AddLast("3");
            nodeList.AddLast("4");
        }
    }

    class Node
    {
        public object Data {get; set;}
        public Node NextNode { get; set; }
    }

    class NodeList
    {
        public Node Head {get; set;}
        public void AddLast(object data)
        {
            if(Head == null)
            {
                AddHead(data);
                return;
            }
            AddNextNode(data);
        }

        private void AddHead(object data)
        {
            Head = new Node() { Data = data };
            return;
        }

        private void AddNextNode(object data)
        {
            Node current = Head;
            while (current.NextNode != null)
            {
                current = current.NextNode;
            }
            current.NextNode = new Node() { Data = data };
        }
    }
 
}
