using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure_Programs
{
    class CustomLinkedList<T>
    {
        public Node<T> head;

        public bool Search(T val)
        {
            Node<T> temp = this.head;
            while (temp != null)
            {
                if (temp.data.Equals(val))
                {
                    Console.WriteLine("Element Found... " + val);
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        public void InsertFront(T new_data)
        {
            Node<T> newNode = new Node<T>(new_data);
            newNode.next = this.head;
            this.head = newNode;
            Console.WriteLine("Inserted the list in front " + newNode.data);
        }
        public void Enqueue(T item)
        {
            Node<T> new_node = new Node<T>(item);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node<T> temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
        }
        public void Display() // This will display the Nodes
        {
            Console.WriteLine("Displaying Nodes !!!");
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
        public void DeleteElement(T data)
        {
            Node<T> temp = head;
            while (temp.next != null)
            {
                if (temp.next.data.Equals(data))
                {
                    Console.WriteLine(" Delete data: {0}", temp.next.data);
                    temp.next = temp.next.next;
                    break;
                }
                else
                {
                    temp = temp.next;
                }
            }
        }
        public string ReturnString()
        {
            string strText = "";
            Node<T> cur = head;
            if (head != null)
            {
                strText += cur.data;
                cur = cur.next;
                while (cur != null)
                {
                    strText = strText + " " + cur.data;
                    cur = cur.next;

                }
                return strText;
            }
            else
            {
                Console.WriteLine("Empty!!!");
                return default;
            }
        }
        public void Sort(T data)
        {
            Node<T> newNode = new Node<T>(data);
            Node<T> temp = head;
            if (head == null || newNode.idata <= head.idata)
            {
                newNode.next = head;
                head = newNode;
            }
            else if (head.next == null && head.idata < newNode.idata)
            {
                head.next = newNode;
            }
            else
            {
                if (temp.next.idata > newNode.idata)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    while (temp.next != null && temp.next.idata < newNode.idata)
                    {
                        temp = temp.next;
                    }
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
            }
        }
        public string DequeuePalindromeChecker()
        {
            string reverseString = " ";
            while (this.head != null)
            {
                if (this.head == null)
                {
                    Console.WriteLine("Queue is Empty");
                }
                reverseString = this.head.data + reverseString;
                head = head.next;   
            }
            return reverseString;
        }
    }
}