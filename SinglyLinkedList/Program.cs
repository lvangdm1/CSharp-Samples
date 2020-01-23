using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList myList = new SinglyLinkedList();
            // insert to first Node
            myList.insertFirst(100);
            myList.insertFirst(50);
            myList.insertFirst(99);
            myList.insertFirst(88);
            // insert to last Node
            myList.insertLast(999000);
            // display list
            myList.displayList();
            // deletes first Node
            myList.deleteFirst();
            // inserts to beginning again
            myList.insertFirst(1234);
            // display list again
            myList.displayList();
        }
    }
    public class SinglyLinkedList
    {
        private Node first;
        public bool isEmpty()
        {
            return (first == null);
        }
        // inserts to first
        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }
        // deletes first
        public Node deleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }
        // display the list
        public void displayList()
        {
            Console.WriteLine("List (first -- last) ");
            Node current = first;
            while (current != null)
            {
                current.displayNode();
                current = current.next;
            }
            Console.WriteLine();
        }
        // inserts to last
        public void insertLast(int data)
        {
            Node current = first;
            while (current.next != null)
            {
                current = current.next;
            }

            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }
    }
    // creates the Node
    public class Node
    {
        public int data;
        public Node next;

        public void displayNode()
        {
            Console.WriteLine("<" + data + ">");
        }
    }
}