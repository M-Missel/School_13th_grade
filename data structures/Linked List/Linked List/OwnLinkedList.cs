using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace Linked_List
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

        public OwnList(IEnumerable<T> data)
        {
            AddRange(data);
        }

        public OwnList(T data)
        {
            AddFirst(data);
        }

        public int Count
        {
            get => GetCount();
        }

        public void AddAfter(T data, int index)
        {
            Node temp = head;
            Node n = new Node(data);
            int numb = 0;

            while (numb < index - 1)
            {
                temp = temp.Next;
                numb++;
            }

            n.Next = temp.Next;
            temp.Next = n;
        }

        public void AddFirst(T data)
        {
            Node n = new Node(data);
            n.Next = head;
            head = n;
        }

        public void AddLast(T data)
        {
            Node n = new Node(data);

            if (head == null)
            {
                head = n;
                return;
            }

            Node lastNode = GetLastNode();
            lastNode.Next = n;
        }

        public void AddRange(IEnumerable<T> data)
        {
            Node node;

            for (int i = 0; i < data.Count(); i++)
            {
                node = GetLastNode();
                Node n = new Node(data.ElementAt(i));
                node.Next = n;
            }
        }

        public void Clear()
        {
            head.Next = null;
            GC.Collect();
        }

        public bool Compare(T nodeData, T equalData)
        {
            return EqualityComparer<T>.Default.Equals(nodeData, equalData);
        }

        public bool Contains(T data)
        {
            Node temp = head;

            while (temp.Next != null)
            {
                if (Compare(temp.Data, data))
                    return true;
            }

            return false;
        }

        public T[] CopyTo()
        {
            Node temp = head;
            T[] newArray = new T[Count];

            for (int i = 0; i < Count; i++)
            {
                newArray[i] = temp.Data;
                temp = temp.Next;
            }

            return newArray;
        }

        public T[] CopyTo(int index)
        {
            Node temp = head;
            T[] newArray = new T[Count - index];
            int numb = 0;

            while (numb < index)
            {
                temp = temp.Next;
                numb++;
            }

            for (int i = 0; i < Count - index; i++)
            {
                newArray[i] = temp.Data;
                temp = temp.Next;
            }

            return newArray;
        }

        public T[] CopyTo(int indexStart, int indexEnd)
        {
            Node temp = head;
            T[] newarray = new T[indexEnd - indexStart];
            int numb = 0;

            while (numb < indexStart)
            {
                temp = temp.Next;
                numb++;
            }

            for (int i = 0; i < indexEnd-indexStart; i++)
            {
                newarray[i] = temp.Data;
                temp = temp.Next;
            }

            return newarray;
        }

        private int GetCount()
        {
            int count = 0; 
            Node temp = head;

            while (temp.Next != null)
            {
                temp = temp.Next;
                count++;
            }

            return count++;
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

        public OwnList<T> GetRange(int indexStart, int indexEnd)
        {
            OwnList<T> list = new OwnList<T>();
            Node temp = head;
            int numb = 0;

            while (numb < indexStart)
            {
                temp = temp.Next;
                numb++;
            }

            for (int i = 0; i < Count - indexEnd; i++)
            {
                list.AddLast(temp.Data);
                temp = temp.Next;
            }

            return list;
        }

        public int IndexOf(T data)
        {
            Node temp = head;
            int index = 0;

            while (temp.Next != null)
            {
                if (Compare(temp.Data, data))
                {
                    return index;
                }
                index++;
            }

            return index = -1;
        }

        public int IndexOf(T data, int indexStart)
        {
            Node temp = head;
            int index, numb = 0;

            while (numb < indexStart)
            {
                temp = temp.Next;
                numb++;
            }

            index = numb;

            while (temp.Next != null)
            {
                if (Compare(temp.Data, data))
                {
                    return index;
                }
                index++;
            }

            return index = -1;
        }

        public int IndexOf(T data, int indexStart, int indexEnd)
        {
            Node temp = head;
            int index, numb = 0;

            while (numb < indexStart)
            {
                temp = temp.Next;
                numb++;
            }

            index = numb;

            while (temp.Next != null && index < indexEnd)
            {
                if (Compare(temp.Data, data))
                {
                    return index;
                }
                index++;
            }

            return index = -1;
        }

        public void Reverse()
        {
            int counter = 0;
            Node temp = head;
            T[] valueCopy = new T[Count];
            T[] valueReverse = new T[Count];

            for (int i = 0; i < Count; i++)
            {
                valueCopy[i] = temp.Data;
                temp = temp.Next;
            }

            throw new NotImplementedException();
        }

        public void Reverse(int indexStart)
        {
            throw new NotImplementedException();
        }

        public void Reverse(int indexStart, int indexEnd)
        {
            throw new NotImplementedException();
        }

        public void RemoveAfter(int index)
        {
            Node temp = head;
            Node n;
            int numb = 0;

            if (index < Count)
            {
                while (numb < index - 1)
                {
                    temp = temp.Next;
                    numb++;
                }

                n = temp.Next;
                temp.Next = n.Next;
            }
        }

        public void RemoveFirst()
        {
            head = head.Next;
        }

        public void RemoveLast()
        {
            if (head.Next == null)
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

        public void RemoveRange(int indexStart, int indexEnd)
        {
            Node temp = head;
            Node n;
            int numb = 0;

            while (numb < indexStart)
            {
                temp = temp.Next;
                numb++;
            }

            n = temp.Next;

            while (numb < indexEnd)
            {
                n = n.Next;
                numb++;
            }

            temp.Next = n;
        }

        public string OwnToString()
        {
            string returnString = "";
            Node temp = head;

            while (temp != null)
            {
                returnString = returnString + temp.Data.ToString();
                temp = temp.Next;
            }

            return returnString;
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