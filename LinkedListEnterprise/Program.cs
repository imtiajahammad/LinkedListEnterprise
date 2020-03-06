using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEnterprise
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddToEnd(1);
            linkedList.AddToEnd(3);
            linkedList.AddToEnd(5);
            linkedList.AddToEnd(7);
            linkedList.AddToFront(0);
            linkedList.AddToFront(-1);
            linkedList.PrintAll();
            Console.WriteLine();
            Console.Write("nodes count is "+linkedList.CountNodes());
            Console.ReadKey();
        }
    }
}
