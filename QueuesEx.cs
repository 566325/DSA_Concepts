using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Concepts
{
    public class QueuesEx
    {
        Node Front;
        Node rear;
        
        public void enqueData(int data)
        {
            Node NodeObj = new Node(data);
            if(Front == null)
            {
                rear = NodeObj;
                Front = rear;
            }
            else
            {
                rear.Next = NodeObj;
                rear = rear.Next;
            }
        }
        public void Display()
        {
            if(Front == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Node temp = Front;
                while(temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.Next;
                }
            }
        }
        
    }
}
