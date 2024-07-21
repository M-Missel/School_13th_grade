using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class OwnStack<T>
    {
        internal class Node
        {
            private T data;
            private Node next;

            public Node(T data)
            {
                this.data = data;
                next = null;
            }

            public T Data
            {
                get => data;
            }

            public Node Next
            {
                get => next;
                set => next = value;
            }
        }

        private Node head;

        public OwnStack()
        {
            head = null;
        }

        public int Count
        {
            get => countElements();
        }

        public void push(T data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        public void pop()
        {
            head = head.Next;
        }

        public T top()
        {
            return head.Data;
        }

        private int countElements()
        {
            int count = 0;
            Node temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }

            return count;
        }
    }
}
