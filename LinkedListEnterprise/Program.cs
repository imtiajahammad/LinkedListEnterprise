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

            /**/
            linkedList.AddToEnd(1);
            linkedList.AddToEnd(3);
            linkedList.AddToEnd(5);
            linkedList.AddToEnd(7);
            /**/
            linkedList.AddToFront(0);
            linkedList.AddToFront(7);
            /**/
            linkedList.PrintAll();
            /**/
            Console.WriteLine();
            Console.Write("Total nodes count is "+linkedList.CountNodes());
            Console.WriteLine();
            /**/
            int searchResult = linkedList.SearchNode(7);
            if(searchResult==0)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("Node found "+searchResult +" times");
            }
            /**/
            bool result=linkedList.InsertionInBetweenNodes(11, 3, 5);
            if (result)
            {
                Console.WriteLine("insertion complete");
            }
            else
            {
                Console.WriteLine("insertion failed");
            }
            linkedList.PrintAll();
            /**/
            Console.ReadKey();
        }
    }
}
