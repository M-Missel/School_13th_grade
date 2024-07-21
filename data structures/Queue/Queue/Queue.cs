using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue<T>
    {
        internal class Node
        {
            private T data;
            private Node next;

            public Node(T data) {
                this.data = data;
                next = null;
            }

            public Node(T data, Node next)
            {
                this.data = data;
                this.next = next;
            }

            public T Data
            {
                get => data;
            }

            public Node NodeElement
            {
                get => next;
                set => next = value;
            }
        }

        private Node head;
        private Node tail;

        public Queue()
        {
            head = null;
            tail = null;
        }

        public int Count
        {
            get => countElement();
        }

        public bool isEmpty()
        {
            return (head == null) ? true : false;
        }

        public void enqueue(T data)
        {
            Node newNode = new Node(data);

            if(head == null)
            {
                head = newNode;
                return;
            }
            if(tail == null)
            {
                tail = newNode;
                head.NodeElement = tail;
                return;
            }
            else
            {
                tail.NodeElement = newNode;
                tail = newNode;
            }

        }

        public void dequeue()
        {
            head = head.NodeElement;
        }

        private int countElement()
        {
            int count = 0;
            Node temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.NodeElement;
            }

            return count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.NodeElement;
            }
        }
    }
}
