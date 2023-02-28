using System;

namespace LinkedListDataStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to data structures program using generics---");
            LinkedList list = new LinkedList();
            LinkedListStack stack = new LinkedListStack();
            LinkedListQueue queue = new LinkedListQueue();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nPlease Select An Option : "
                    + "\n1.Add Data Into LiknkedList"
                    + "\n2.Display Linked List"
                    + "\n3.Add Data By Reverse Order Into LinkedList"
                    + "\n4.Appending Data Into LinkedList"
                    + "\n6.Remove First Node From LinkedList"
                    + "\n7.Remove Last Node From LinkedList"
                    + "\n8.Size Of LinkedList"
                    + "\n9.Search Element into LinkedList"
                    + "\n10.Stack Push Data"
                    + "\n11.Stack Pop Data"
                    + "\n12.Queue Enqueue Data"
                    + "\n13.Queue Dequeue Data"
                    + "\n14.Exit\n"); ;
                int option =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                switch (option)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        break;
                    case 2:
                        list.Display();
                        break;
                    case 3:
                        list.ReversOrder(70);
                        list.ReversOrder(30);
                        list.ReversOrder(56);
                        list.Display();
                        break;
                    case 4:
                        list.Append(56);
                        list.Append(30);
                        list.Append(70);
                        list.Display();
                        break;
                    case 6:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.RemoveFirstNode();
                        list.Display();
                        break;
                    case 7:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.RemoveLastNode();
                        list.Display();
                        break;
                    case 8:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.Add(45);
                        list.Add(90);
                        list.Add(16);
                        Console.WriteLine(" ");
                        list.Size();
                        break;
                    case 9:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.Add(30);
                        list.Add(90);
                        list.Add(16);
                        //Console.WriteLine(" ");
                        //list.Display();
                        Console.WriteLine(" ");
                        list.SearchValue(30);
                        break;
                    case 10:
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);
                        Console.WriteLine(" ");
                        stack.Display();
                        Console.WriteLine(" ");
                        break;
                    case 11:
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);
                        Console.WriteLine(" ");
                        stack.Display();
                        stack.IsEmpty();
                        break;
                    case 12:
                        queue.Enqueue(10);
                        queue.Enqueue(20);
                        queue.Enqueue(30);
                        queue.Display();
                        break;
                    case 13:
                        queue.Enqueue(10);
                        queue.Enqueue(20);
                        queue.Enqueue(30);
                        Console.WriteLine("\nThe Queue Before Dequeue.");
                        queue.Display();
                        Console.WriteLine("\nThe Queue After Dequeue.");
                        queue.Dequeue();
                        break;
                    case 14:
                        Console.WriteLine("Thank you !!!");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Selected Wrong Option Please Select Right Option !!!");
                        break;
                }
            }
        }
    }
}