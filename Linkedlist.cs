using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Concepts
{
    public class Linkedlist
    {
        public Node head;

        public void AddNode(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                head = node;

            }
            else
            {
                Node temp = head;
                while(temp.Next != null)
                {
                    temp = temp.Next;

                }
                temp.Next = node;

            }
            Console.WriteLine("{0} is inserted into the Linkedlist", data);
        }
        public void Display()
        {
            if(head == null)
            {
                Console.WriteLine("Linked list is Empty");
            }
            else
            {
                Node tempnode = head;
                while(tempnode != null)
                {
                    Console.WriteLine(tempnode.data + " ");
                    tempnode = tempnode.Next;
                }
            }
        }
        public Node InsertAtPerticularPosition(int position ,int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            if (position == 1)
            {
                var temp = new Node(data);
                temp.Next = head;
                head = temp;
            }
            else
            {
                while(position != 0)
                {
                    if(position == 1)
                    {
                        Node node = new Node(data);
                        node.Next = this.head.Next;
                        head.Next = node;
                        break;
                    }
                    head = head.Next;
                }
                if(position != 1)
                {
                    Console.WriteLine("Position out of the Range");
                }
            }
            return head;
        }
        public Node RemoveFirstNode()
        {
            if(this.head == null)
            {
                return null;
            }
            this.head =this.head.Next;
            return this.head;
        }
        public Node RemoveLastNode()
        {
            if(head == null)
            {
                return null;
            }
            if(head.Next == null)
            {
                return null;
            }
            Node temp = head;
            while(temp.Next.Next != null)
            {
                temp= temp.Next;
            }
            temp.Next = null;
            return head;
        }
        public Node Search(int values)
        {
            while(this.head != null)
            {
                if (this.head.data == values)
                {
                    return this.head;
                }
                this.head=this.head.Next;
            }
            Console.WriteLine("donot match the values");
            return null;

        }

    }

}
