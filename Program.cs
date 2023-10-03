namespace DataStructures_Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {

            QueueOperations queue = new QueueOperations();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine("*******elements in queue*********");
            queue.display();
            queue.dequeue();
            Console.WriteLine("Elements in queue after Dequeue");
            queue.display();
            queue.dequeue();
            Console.WriteLine("Elements in queue after Dequeue");
            queue.display();
            queue.dequeue();
            Console.WriteLine("Elements in queue after Dequeue");
            queue.display();

            //LinkedList<int> list = new LinkedList<int>();
            //list.AddFirst(56);
            //list.AddLast(30);
            //list.AddLast(70);

            //foreach (int data in list)
            //{
            //    Console.WriteLine(data);
            //}


            //Console.WriteLine("*************************");

            //Linkedlist linkedList = new Linkedlist();
            //linkedList.AddNode(56);
            //linkedList.AddNode(30);
            //linkedList.AddNode(70);
            //linkedList.Display();
            //Console.WriteLine("Add first perticular positon in the list");
            //linkedList.InsertAtPerticularPosition(1,80);
            //linkedList.Display();
            //Console.WriteLine("Remove the First element in the list");
            //linkedList.RemoveFirstNode();
            //linkedList.Display();
            //Console.WriteLine("remove last element in the list");
            //linkedList.RemoveLastNode();
            //linkedList.Display();
            //linkedList.Search(78);



            //Stacks Obj= new Stacks();
            //Obj.pushdata(70);
            //Obj.pushdata(30);
            //Obj.pushdata(56);
            //Console.WriteLine("Elements in the Stack :");

            //Obj.display();

            //Queues
            //QueuesEx Obj = new QueuesEx();
            //Obj.enqueData(56);
            //Obj.enqueData(30);
            //Obj.enqueData(70);
            //Console.WriteLine("Elements in the Queue are :");

            //Obj.Display();

        }
    }
}