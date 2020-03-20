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
                Console.WriteLine("InsertionInBetweenNodes complete");
            }
            else
            {
                Console.WriteLine("InsertionInBetweenNodes failed");
            }
            linkedList.PrintAll();
            Console.WriteLine();
            /**/
            bool resul1t = linkedList.InsertionAfterSpecifiedNode(7, 33);
            if (resul1t)
            {
                Console.WriteLine("InsertionAfterSpecifiedNode complete");
            }
            else
            {
                Console.WriteLine("InsertionAfterSpecifiedNode failed");
            }
            linkedList.PrintAll();
            Console.WriteLine();
            /**/

            /**/
            bool resul2t = linkedList.InsertionBeforeSpecifiedNode(33, 333);
            if (resul2t)
            {
                Console.WriteLine("InsertionBeforeSpecifiedNode complete");
            }
            else
            {
                Console.WriteLine("InsertionBeforeSpecifiedNode failed");
            }
            linkedList.PrintAll();
            Console.WriteLine();
            /**/
            Console.Write("Total nodes count is " + linkedList.CountNodes());
            Console.WriteLine();
            linkedList.PrintAll();
            Console.WriteLine();
            bool resul3t = linkedList.InsertionOnGivenPosition(-10, 111);
            if (resul3t)
            {
                Console.WriteLine("InsertionOnGivenPosition complete");
            }
            else
            {
                Console.WriteLine("InsertionOnGivenPosition failed");
            }
            linkedList.PrintAll();
            Console.WriteLine();
            /**/

            /*delete first node*/
            bool result4 =linkedList.DeleteFirstNode();
            if (result4)
            {
                Console.WriteLine("DeleteFirstNode complete");
            }
            else
            {
                Console.WriteLine("DeleteFirstNode failed");
            }
            linkedList.PrintAll();
            /*delete first node*/


            /*delete last node*/
            
            bool result5 = linkedList.DeleteLastNode();
            if (result5)
            {
                Console.WriteLine("DeleteLastNode complete");
            }
            else
            {
                Console.WriteLine("DeleteLastNode failed");
            }
            linkedList.PrintAll();
            /*delete last node*/

            /*delete specific node*/
            bool result6 = linkedList.DeleteSpecificNode(3);
            if (result6)
            {
                Console.WriteLine("DeleteSpecificNode complete");
            }
            else
            {
                Console.WriteLine("DeleteSpecificNode failed");
            }
            linkedList.PrintAll();
            /*delete specific node*/

            Console.ReadKey();
        }
    }
}
