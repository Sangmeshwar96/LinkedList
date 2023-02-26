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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nPlease Select An Option : "+"\n1.Add Data Into LiknkedList\n"+"2.Display Linked List" + "\n3.Add Data By Reverse Order Into LinkedList"
                    + "\n4.Appending Data Into LinkedList" +"\n6.Remove First Node From LinkedList" + "\n7.Remove Last Node From LinkedList" +"\n8.Size Of LinkedList"+"\n9.Stack Push Data"+ "\n10.Exit");
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
                        stack.Push(56);
                        stack.Push(56);
                        stack.Push(56);
                        Console.WriteLine(" ");
                        stack.Display();
                        Console.WriteLine(" ");
                        break;
                    case 10:
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