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
            if(headNode is null)
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
            return true;
        }
        public bool DeleteLastNode()
        {
            return true;
        }
        public bool DeleteSpecificNode(int data)
        {
            return true;
        }

        public void DeleteTheOnlyNode()
        {
        }
        public void DeleteInBetweenNode(int firstNode,int lastNode,int data)
        {
        }

    }
}
