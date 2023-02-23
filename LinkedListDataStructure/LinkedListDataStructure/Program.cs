using System;

namespace LinkedListDataStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to data structures program using generics---");
            LinkedList list = new LinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nPlease Select An Option : "+"\n1.Add Data Into LiknkedList\n"+"2.Display Linked List\n");
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