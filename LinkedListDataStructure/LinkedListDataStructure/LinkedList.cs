using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"Added {node.data} to the list");
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " \n");
                temp = temp.next;
            }
            Console.WriteLine("\n ______________________________________________________________________");
        }
        public void ReversOrder(int data)
        {
            Node newNode = new Node(data);
            if(this.head == null)
                this.head = newNode;
            else
            {
                Node tempNode = this.head;
                head = newNode;
                head.next = tempNode;
            }
            Console.WriteLine(newNode.data + " Is inserted into LinkedList.");
        }
        public void Append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data + " Appended into Linked List");
        }
        public void RemoveFirstNode()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty.");
            }
            this.head = this.head.next;
            Console.WriteLine("The First Element is Deleted.");
        }
        public void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty.");
            }
            if (head.next == null)
            {
                head.next = null;
            }
            else
            {
                Node lastNode = this.head;
                while (lastNode.next.next != null)
                {
                    lastNode = lastNode.next;
                }
                lastNode.next = null;
                Console.WriteLine("The Last Element is Deleted.");
            }
        }
        public void SearchValue(int value)
        {
            bool doesExists = false;
            if (head != null)
            {
                int count = 0;
                Node temp = head;
                while(temp != null)
                {
                    if(temp.data == value)
                    {
                        doesExists = true;
                        count++;
                    }
                    temp = temp.next;
                }
                if(doesExists)
                {
                    Console.WriteLine(value+" exists "+count+" times.\n");
                }
                else
                {
                    Console.WriteLine(value+"is not present in LinkedList.");
                }
                Display();
            }
        }
        public void Size()
        {
            Node temp = head;
            int count = 0;
            if(temp==null)
            {
                Console.WriteLine("Linked List is empty.");
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine(count);

        }
    }
}