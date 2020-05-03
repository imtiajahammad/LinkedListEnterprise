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
            Console.Write("Total nodes count is " + linkedList.CountNodes());
            Console.WriteLine();
            /**/
            int searchResult = linkedList.SearchNode(7);
            if (searchResult == 0)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("Node found " + searchResult + " times");
            }
            /**/
            bool result = linkedList.InsertionInBetweenNodes(11, 3, 5);
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
            bool result4 = linkedList.DeleteFirstNode();
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


            /*DeleteTheOnlyNode()*/
            bool result7 = linkedList.DeleteTheOnlyNode();
            if (result7)
            {
                Console.WriteLine("DeleteTheOnlyNode complete");
            }
            else
            {
                Console.WriteLine("DeleteTheOnlyNode failed");
            }
            linkedList.PrintAll();
            /*DeleteTheOnlyNode()*/


            /*DeleteInBetweenNode*/
            bool result8 = linkedList.DeleteInBetweenNode(1, 5, 11);
            if (result8)
            {
                Console.WriteLine("DeleteInBetweenNode complete");
            }
            else
            {
                Console.WriteLine("DeleteInBetweenNode failed");
            }
            linkedList.PrintAll();
            /*DeleteInBetweenNode*/


            /*ReverseList*/
            Console.WriteLine("ReverseList-start");
            LinkedList result9 = new LinkedList();
            result9 = linkedList.ReverseLinkedList();
            result9.PrintAll();
            Console.WriteLine("ReverseList with no node-start");
            linkedList = new LinkedList();
            LinkedList result10 = new LinkedList();
            result10 = linkedList.ReverseLinkedList();
            result10.PrintAll();
            Console.WriteLine("ReverseList with no node-end");

            Console.WriteLine("ReverseList-end");
            /*ReverseList*/


            /*Bubble Sort Practice*/
            //int[] array ={11, 51, 81,8, 61, 1, 45};
            int[] array ={1, 5, 8,80, 611, 612, 600};
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "--");
            }
            Console.WriteLine();
            for (int loop = 0; loop < array.Length; loop++)
            {
                bool flag=false;
                for(int each = 0; each < array.Length-1-loop; each++)
                {
                    //Console.WriteLine(array[each] + "++" + array[each + 1]);
                    if (array[each] > array[each + 1])
                    {
                        int temp = array[each];
                        array[each] = array[each + 1];
                        array[each + 1] = temp;
                        flag=true;
                    }
                }
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "---");
            }
            Console.WriteLine(flag);
            if(flag==false)
                {
                    break;
                }
            }


            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "--");
            }


            /*Bubble Sort Practice*/
            Console.ReadKey();
        }
    }
}
