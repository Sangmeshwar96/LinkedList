using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    public class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }

        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(value + " pushed to stack");
        }

        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("\nStack is Empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("\nStack is Empty");
                return;
            }
            Console.WriteLine("\n"+ this.top.data + " is in top of stack");
        }

        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty,Deletion is not Possible");
                return;
            }
            Console.WriteLine("Value Popped is "+ this.top.data);
            this.top = this.top.next;
        }

        public void IsEmpty()
        {
            while (this.top != null)
            {
                Console.WriteLine(" ");
                Peek();
                Pop();
                Console.WriteLine(" ");
                Display();
            }
        }
    }
}
