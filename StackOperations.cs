using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Concepts
{
    class NodeS
    {
        public int data;
        public NodeS next;
    }
    public class StackOperations
    {
        private NodeS top;
        public StackOperations()
        {
            this.top = null;
        }
        public void Push(int data)
        {
            NodeS node = new NodeS();
            node.data = data;

            if (isEmpty() == true)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine($"element pushed to stack: {node.data}");
        }
        public void display()
        {
            NodeS n = this.top;
            while (n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }
        public void Pop()
        {
            if (isEmpty() == true)
            {
                Console.WriteLine("No elements to remove.");
            }
            if (this.top != null)
            {
                Console.WriteLine($"popped element: {this.top.data}");
                this.top = this.top.next;
            }
        }
        public bool isEmpty()
        {
            if (this.top == null)
                return true;
            else
                return false;
        }
        public void Peek()
        {
            if (isEmpty() == true)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                Console.WriteLine($"top element: {this.top.data}");
            }
        }
        public int Size()
        {
            int count = 0;
            NodeS n = top;
            while (n != null)
            {
                count++;
                n = n.next;
            }
            Console.WriteLine($"size of stack: {count}");
            return count;
        }




    }
}
