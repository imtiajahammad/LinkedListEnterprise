using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEnterprise
{
    public class LinkedList
    {
        public Node headNode { get; set; }

        public void AddToEnd(int data)
        {
            if(headNode is null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = headNode; 
                while(temp.next != null)
                {
                    temp= temp.next;
                }
                Node newNode = new Node(data);
                temp.next = newNode;
            }
        }
        public void PrintAll()
        {
            Console.WriteLine();
            if (headNode is null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                Node temp = headNode;
                Console.Write("|"+temp.data);
                while (temp.next != null)
                {
                    temp = temp.next;
                    Console.Write(">"+temp.data );
                }
            }
            Console.WriteLine();
        }
        public void AddToFront(int data)
        {
            if (headNode is null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node newNode = new Node(data);
                newNode.next = headNode;
                headNode = newNode;
            }
        }
        public int CountNodes()
        {
            int count = 0;
            Node temp = headNode;
            if (headNode != null)
            {
                do
                {
                    count++;
                    temp = temp.next;
                } while (temp != null);
            }
            return count;
        }
        public int SearchNode(int data)
        {
            int count = 0;
            Node temp = headNode;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    count++;
                }
                temp = temp.next;
            }
            return count;
        }
        public bool InsertionInBetweenNodes(int data,int firstNode,int endNode)
        {
            Node temp = headNode;
            bool result = false;
            if(temp is null)
            {
                headNode = new Node(data);
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data == firstNode && temp.next.data == endNode)
                    {
                        Node newNode = new Node(data);
                        newNode.next = temp.next;
                        temp.next = newNode;
                        result = true;
                        break;
                    }
                    temp = temp.next;
                }
            }

            return result;
        }
        public bool InsertionAfterSpecifiedNode(int specifiedNode,int data)
        {
            Node temp = headNode;
            bool result = false;
            if(temp is null)
            {
                headNode = new Node(data);
                result = true;
            }
            else
            {
                while(temp.next!=null){
                    if (temp.data == specifiedNode)
                    {
                        Node newNode = new Node(data);
                        newNode.next = temp.next;
                        temp.next = newNode;
                        result = true;
                        break;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
            }
            return result;
        }
        public bool InsertionBeforeSpecifiedNode(int specifiedNode, int data)
        {
            bool result = false;
            Node temp = headNode;
            if(temp is null)
            {
                headNode = new Node(data);
                result = true;
            }
            else
            {
                while (temp.next != null)
                {
                    if (temp.next.data == specifiedNode)
                    {
                        Node newNode = new Node(data);
                        newNode.next = temp.next;
                        temp.next = newNode;
                        result = true;
                        break;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
            }
            return result;
        }
        public bool InsertionOnGivenPosition(int position,int data)
        {
            position = position - 1;
            bool result = false;
            int count = 0;
            Node temp = headNode;
            int totalNodesCount = CountNodes()-1;
            if (temp is null)
            {
                headNode = new Node(data);
            }
            else
            {
                if (position <= 0)
                {
                    AddToFront(data);
                    result = true;
                    return result;
                }
                else if (position>totalNodesCount)
                {
                    AddToEnd(data);
                    result = true;
                    return result;
                }
                else if(position==totalNodesCount)
                {
                    Node previousNode = headNode;
                    while (temp.next != null)
                    {
                            previousNode = temp;
                            temp = temp.next;
                    }
                    Node newNode = new Node(data);
                    newNode.next = temp;
                    previousNode.next = newNode;
                    result = true;
                }
                else
                {
                    Node previousNode = headNode;
                    while (temp.next != null)
                    {
                        if (count == position)
                        {
                            Node newNode = new Node(data);
                            newNode.next = temp;
                            previousNode.next = newNode;
                            result = true;
                            break;
                        }
                        else
                        {
                            previousNode = temp;
                            temp = temp.next;
                            count++;
                        }
                    }
                }

            }
            return result;
        }

        

        public bool DeleteFirstNode()
        {
            bool result = false;
            if(headNode is null)
            {
                result = false;
            }
            else
            {
                headNode = headNode.next;
                result = true;
            }
            return result;
        }
        public bool DeleteLastNode()
        {
            bool result = false;
            if(headNode is null)
            {
                result = false;
            }
            else
            {
                Node temp = headNode;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
                result = true;
            }
            return result;
        }
        public bool DeleteSpecificNode(int data)
        {
            bool result = false;
            if(headNode is null)
            {
                result = false;
            }
            else
            {

                if (headNode.data == data)
                {
                    headNode = headNode.next;
                    result = true;
                }
                else
                {
                    Node temp = headNode;
                    Node previousNode = null;
                    while (temp.next != null)
                    {
                        previousNode = temp;
                        temp = temp.next;
                        if (temp.data == data)
                        {
                            previousNode.next = temp.next;
                            result = true;
                            break;
                        }
                    }
                }
            }
            return result;
        }

        public bool DeleteTheOnlyNode()
        {
            bool result = false;
            if (headNode.next == null)
            {
                /*in this case, the list contain only one node and this function needs to delete that*/
                headNode = null;
                result = true;
            }
            return result;
        }
        public bool DeleteInBetweenNode(int firstNode,int lastNode,int data)
        {
            bool result = false;
            if (headNode == null)
            {
                result = false;
            }
            else
            {
                Node temp = headNode;
                while (temp.next != null)
                {
                    if (temp.data == firstNode)
                    {
                        if (temp.next.next.data == lastNode)
                        {
                            if (temp.next.data == data)
                            {
                                temp.next = temp.next.next;
                                result = true;
                                break;
                            }
                        }
                    }
                    temp = temp.next;
                }
            }
            return result;
        }
        public LinkedList ReverseLinkedList()
        {
            LinkedList returnList = new LinkedList();
            if (headNode is null)
            {
                return returnList;
                //returnList = null;
            }
            else
            {

                Node temp = headNode;
                while (temp.next != null)
                {
                    returnList.AddToFront(temp.data);
                    temp = temp.next;
                }
                returnList.AddToFront(temp.data);
            }
            return returnList;
        }
        public bool BubbleSortByExchangeData()
        {
            bool result = false;
            return result;
        }
        public bool BubbleSortByExchangeLinks()
        {
            bool result = false;
            return result;
        }
        public bool MergeSort()
        {
            bool result = false;
            return result;
        }
        public bool InsertCycle()
        {
            bool result = false;
            return result;
        }
        public bool DeleteCycle()
        {
            bool result = false;
            return result;
        }
        public bool RemoveCycle()
        {
            bool result = false;
            return result;
        }
        public bool FindingReferenceToTheLastNode()
        {
            bool result = false;
            return result;
        }
        public bool FindingReferenceToTheSecondLastNode()
        {
            bool result = false;
            return result;
        }
        public bool FindingReferenceToANodeWithParticularInfo()
        {
            bool result = false;
            return result;
        }
        public bool FindingReferenceToPredecessorOfANodeWithParticularInfo()
        {
            bool result = false;
            return result;
        }
        public bool FindingReferenceToANodeAtAParticularPosition()
        {
            bool result = false;
            return result;
        }
        public bool MakeTwoSortedLinkedListIntoSingleLinkedListWithRecursiveProcedure()
        {
            bool result = false;
            return result;
        }







    }
}
