using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Concepts
{
    class NodeQ
    {
        public int data;
        public NodeQ next;
    }
    class QueueOperations
    {
        public NodeQ top;
        public QueueOperations()
        {
            this.top = null;
        }

        public bool isEmpty()
        {
            if (this.top == null)
                return true;
            else
                return false;
        }
        public void Enqueue(int data)
        {
            NodeQ node = new NodeQ();
            node.data = data;
            if (isEmpty() == true)
            {
                this.top = node;
                node.next = null;
            }
            else
            {
                NodeQ n = top;

                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
            Console.WriteLine($"element add to Queue: {node.data}");
        }
        internal void dequeue()
        {
            if (isEmpty() == true)
            {
                Console.WriteLine("Queue empty!!");
            }
            if (Size() == 1)
            {
                Console.WriteLine($"Dequeued element: {top.data}");
                this.top = null;
            }
            if (Size() > 1)
            {
                NodeQ n = this.top;
                this.top = n.next;
                Console.WriteLine($"Dequeued element: {n.data}");
            }
        }
        internal int Size()
        {
            int count = 0;
            NodeQ n = this.top;
            while (n != null)
            {
                count++;
                n = n.next;
            }
            
            return count;
        }
        internal void display()
        {
            NodeQ n = this.top;
            if (isEmpty() == true)
            {
                Console.WriteLine("Queue Empty!!!");
            }
            while (n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }


    }
    
    

}
