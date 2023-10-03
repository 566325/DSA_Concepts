using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Concepts
{
    public class Stacks
    {
        public static void StacksExample() 
        {
            Stack obj = new Stack();

            obj.Push(1);
            obj.Push(2);
            obj.Push(3);
            obj.Push(4);

            foreach (var i in obj)
            {
                Console.WriteLine(i);
            }
            obj.Pop();
            Console.WriteLine("======================");

            foreach(var i in obj)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("========================");
            Console.WriteLine(obj.Peek());
        }
        Node top;
        public Stacks()
        {
            top = null;
        }
        public void pushdata(int data)
        {
            Node nodeobj = new Node(data);
            nodeobj.Next = top;
            top = nodeobj;
            Console.WriteLine("{0} is inserted inro the stack :", data);
        }

        public void display()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.WriteLine(temp.data+ " ");
                    temp = temp.Next;
                }
            }
        }
    }
}
