using System;

namespace LinearListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            list.Delete(1);
            list.Delete(3);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }

  
}
