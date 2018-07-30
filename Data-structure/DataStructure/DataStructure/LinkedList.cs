using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Node
    {
        public int data;
        public Node next;
    }

    class LinkedList : Imanipulations
    {
        public Node AddElement(int value, Node head)
        {
            Node newNode = new Node();

            newNode.data = value;
            newNode.next = null;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node nextNode;
                if (head != null)
                {
                    nextNode = head;
                    while (nextNode != null && nextNode.next != null)
                    {

                        nextNode = nextNode.next;
                    }

                    nextNode.next = newNode;

                }


            }
            return head;
        }

        public virtual Node RemElement(Node head)
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;

            Node node = head;
            while (node.next.next != null)
                node = node.next;
            node.next = null;

            return head;

        }

        public virtual Node Sort(Node head)
        {

            int s = 1;
            if (head == null || head.next == null)
                return head;
            else
            {
                while (s == 1)
                {
                    s = 0;
                    Node nn = head.next;
                    Node prev = head;

                    while (nn != null)
                    {

                        if (prev.data > nn.data)
                        {
                            s = 1;
                            int t = nn.data;
                            nn.data = prev.data;
                            prev.data = t;

                        }

                        prev = nn;
                        nn = nn.next;
                    }
                }
            }
            return head;
        }





           


        public virtual void Display(Node head)
        {
            Node node = head;


            while (node != null)
            {
                Console.WriteLine("{0}", node.data);
                node = node.next;

            }


        }


        public Node InsertAtPos(int value, int index, Node head)
        {
            int c = index;
            Node newNode = new Node();
            newNode.data = value;
            newNode.next = null;

            int i = 0;
            Node node;
            if (index == 1)
            {
                newNode.next = head;
                head = newNode;
                return newNode;
            }

            node = head;
            c = c - 2;
            while (i < c && node.next != null)
            {
                node = node.next;
                i++;
            }
            newNode.next = node.next;
            node.next = newNode;

            return head;
        }


        public Node RemoveAtPos(int index, Node head)
        {

            int i = 0;
            Node node = head;
            if (index == 1)
            {

                return head.next;
            }
            index = index - 2;
            while (i < index && node.next != null)
            {

                node = node.next;
                i++;
            }
            if (node.next == null)
            {
                Console.WriteLine("invalid position");

            }

            else if (node.next != null)
            {
                node.next = node.next.next;
            }
            return head;

        }

    }
}






