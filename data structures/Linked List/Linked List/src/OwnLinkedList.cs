using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List.src
{
    public class OwnList<T>
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
                set => data = value;
            }

            public Node Next
            {
                get => next;
                set => next = value;
            }
        }

        private Node head;

        public OwnList()
        {
            head = null;
        }

        public void Add(T data)
        {
            Node n = new Node(data);
            head = n;
        }

        public void AddAfter(T data)
        {
            throw new NotImplementedException();
        }

        public void AddLast(T data)
        {
            Node n = new Node(data);

            if (head == null)
            {
                head = n;
            }

            Node lastNode = GetLastNode();
            lastNode.Next = n;
        }

        public void Remove()
        {
            head = head.Next;
        }

        public void RemoveAfter()
        {
            throw new NotImplementedException();
        }

        public void RemoveLast()
        {
            if(head.Next == null)
                head = null;
            else
            {
                Node current = head;
                Node previous = null;

                while (current.Next != null)
                {
                    previous = current;
                    current = current.Next;
                }

                previous.Next = current.Next;
            }
        }

        private Node GetLastNode()
        {
            Node temp = head;

            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            return temp;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
