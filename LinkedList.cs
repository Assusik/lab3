using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class LinkedList<T>
    {

        private Node<T> head;
        private int count;
        public LinkedList()
        {
            head = null;
            count = 0;
        }
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = head;
            head = newNode;
            count++;
        }

        public void PrintList()
        {
            if (head != null)
            {
                Node<T> tempHead = head;
                Console.WriteLine(tempHead.Data.ToString());
                while (tempHead.Next != null)
                {
                    tempHead = tempHead.Next;
                    Console.WriteLine(tempHead.Data.ToString());

                }
            }
            else
            {
                Console.WriteLine("pusto");
            }
        }

        public void AddLast(T data)
        {
            if (head == null)
            {
                AddFirst(data);
                return;
            }
            Node<T> newNode = new Node<T>(data);
            Node<T> tempHead = head;

            while (tempHead.Next != null)
            {
                tempHead = tempHead.Next;
            }
            tempHead.Next = newNode;
        }
        public int Count
        {
            get { return count; }
        }
    }
}
