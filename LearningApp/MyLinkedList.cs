using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int a)
        {
            this.data = a;
            this.next = null;
        }
    }
    
    public class MyLinkedList
    { 
        public Node start = null;
        public int length { get { return getLength(); } }
        public void PrintList()
        {
            Node current = start;
            while (current != null)
            {
                Console.Write(current.data + " > ");
                current = current.next;
            }
        }
        private int getLength()
        {
            int len = 0;
            Node current = start;
            while (current != null)
            {
                len++;
                current = current.next;
            }
            return len;
        }
        public void AddNewFirst(int i)
        {
            Node newNode = new Node(i);
            if (start == null)
            {
                start = newNode;
            }
            else
            {
                newNode.next = start;
                start = newNode;
            }
        }
        public void AddNewLast(int i)
        {
            Node newNode = new Node(i);
            if (start == null)
            {
                start = newNode;
            }
            else
            {
                Node current = start;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
        }
        public void AddAt(int at, int i)
        {
            if (at > length+1 )
            {
                //return;
                Console.Write("can not add at " + at + " location because List has "+length+" items");
            }
        }

    }

    
}
