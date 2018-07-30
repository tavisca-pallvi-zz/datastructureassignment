using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{

    class Queue:LinkedList,Imanipulations
    {
        
        public override Node  RemElement(Node queue)
        {
            if (queue == null)
                return null;
            if (queue.next == null)
                return null;

            queue = queue.next;
            return queue;


        }
        

        public int IsEmpty(Node queue)
        {

            if (queue == null)
                return 1;
            else
                return 0;

        }
        public int Peek(Node queue)
        {
            if (queue == null)
            {
                Console.WriteLine("queue is empty");
                return -1;
            }
            else
            {
                return queue.data;

            }

        }
        int length(Node queue, int size)
        {
            int c = 0;
            while (queue != null)
            {
                c++;
                queue = queue.next;

            }

            return c;

        }
        public int IsFull(Node queue, int size)
        {

            int c = length(queue, size);

            if (c == size)
                return 1;

            return 0;



        }

    }
}

