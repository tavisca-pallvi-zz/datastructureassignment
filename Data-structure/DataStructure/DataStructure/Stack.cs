using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Stack:LinkedList, Imanipulations
    {
        
        public override void Display(Node stack)
        {
            Node node = stack;
            List<int> t=new List<int>();

            while (node != null)
            {
                t.Add(node.data);
                
                node = node.next;

            }
            int c = t.Count - 1;
            while (c >= 0) { 
                Console.WriteLine("{0}", t[c]);
                c--;
            }


        }
        
        public int Peek(Node stack)
        {
            if (stack == null)
            {
                Console.WriteLine("stack is empty");
                return -1;
            }
            while (stack.next != null)
            {
                stack = stack.next;

            }
            return stack.data;


        }



    }
}

