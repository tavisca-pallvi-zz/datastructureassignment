using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {

        static void Main(string[] args)
        {
            int s = 5, index;

            Queue queue;
            LinkedList linkList;
            Stack stack;
            Node sNode = null, qNode = null, lNode = null;
            char flag = 'y', ch, c;
            while (flag == 'y')
            {
                Console.WriteLine("Do you want to continue");
                flag = (Console.ReadKey().KeyChar);
                if (flag != 'y')

                    break;

                Console.WriteLine("What operation you want to  perform\n" + "Press 'a' for adding \n" + "Press 'r' for remove \n" + "Press 'd' for display \n" + "Press 'f' to check if queue is full \n" + "Press 'e' to check if queue is empty \n" + "Press 'p' to get queue peek value \n" + "Press 'i' to remove element from specific pos\n" + "Press 'c' to insert at pos in ll  \n" + "Press 'h' to get  stack top value \n");
                c = Console.ReadKey().KeyChar;
                if (c == 'p' || c == 'f' || c == 'e')
                {
                    Console.WriteLine("you can perform only for queues");

                    ch = 'q';
                }
                else if (c == 'h')
                {
                    Console.WriteLine("you can perform only for stack");
                    ch = 's';
                }
                else if (c == 'i' || c == 'c')
                {
                    Console.WriteLine("you can perform only for linkedlist");
                    ch = 'l';
                }
                else
                {
                    Console.WriteLine("What data structure want to work on\n" + "Press 'l' for linkedlist \n" + "Press 'q' for queue \n" + "Press 's' for stack \n");

                    ch = Console.ReadKey().KeyChar;

                }
                switch (c)
                {

                    case 'a':

                        Console.WriteLine("Enter element");
                        int n = Int32.Parse(Console.ReadLine());

                        if (ch == 'q')
                        {
                            queue = new Queue();

                            qNode = queue.AddElement(n, qNode);
                        }
                        else if (ch == 's')
                        {
                            stack = new Stack();

                            sNode = stack.AddElement(n, sNode);
                        }
                        else if (ch == 'l')
                        {
                            linkList = new LinkedList();
                            lNode = linkList.AddElement(n, lNode);
                        }

                        break;

                    case 'r':

                        if (ch == 'q')
                        {
                            queue = new Queue();
                            qNode = queue.RemElement(qNode);
                        }

                        else if (ch == 's')
                        {
                            stack = new Stack();
                            sNode = stack.RemElement(sNode);
                        }
                        else if (ch == 'l')
                        {
                            linkList = new LinkedList();
                            lNode = linkList.RemElement(lNode);
                        }

                        break;

                    case 'd':

                        if (ch == 'q')
                        {
                            queue = new Queue();
                            queue.Display(qNode);
                        }

                        else if (ch == 's')
                        {
                            stack = new Stack();
                            stack.Display(sNode);

                        }
                        else if (ch == 'l')
                        {
                            linkList = new LinkedList();
                            linkList.Display(lNode);
                        }
                        break;

                    case 's':

                        if (ch == 'q')
                        {
                            queue = new Queue();
                            qNode=queue.Sort(qNode);
                        }

                        else if (ch == 's')
                        {
                            stack = new Stack();
                           sNode= stack.Sort(sNode);

                        }
                        else if (ch == 'l')
                        {
                            linkList = new LinkedList();
                           lNode= linkList.Sort(lNode);
                        }
                        break;

                    case 'f':

                        queue = new Queue();
                        Console.WriteLine(queue.IsFull(qNode, s));
                        break;

                    case 'e':

                        queue = new Queue();
                        Console.WriteLine(queue.IsEmpty(qNode));
                        break;

                    case 'c':

                        Console.WriteLine("Enter element");
                        n = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter index");
                        index = Int32.Parse(Console.ReadLine());
                        linkList = new LinkedList();
                        lNode = linkList.InsertAtPos(n, index, lNode);
                        break;

                    case 'i':

                        index = Int32.Parse(Console.ReadLine());
                        linkList = new LinkedList();
                        lNode = linkList.RemoveAtPos(index, lNode);
                        break;

                    case 'h':

                        stack = new Stack();
                        Console.WriteLine(stack.Peek(sNode));
                        break;

                    case 'p':

                        queue = new Queue();
                        Console.WriteLine(queue.Peek(qNode));
                        break;

                }




            }
            Console.ReadLine();

        }
    }

}













