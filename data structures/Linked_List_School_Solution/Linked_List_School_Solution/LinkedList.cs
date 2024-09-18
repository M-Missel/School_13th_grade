using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linked_List_School_Solution
{
    class LinkedList<T>
    {
        private Node<T> head;

        public LinkedList()
        {
            head = null;
        }

        public int anzahlElemente()
        {
            Node<T> n = head;
            int numb = 0;

            while (n != null)
            {
                numb++;
                n = n.gibNaechsten();
            }

            return numb;
        }

        public T inhalt(int pIndex)
        {
            T data;
            Node<T> n = head;

            for (int i = 0; i < pIndex; i++)
            {
                n = n.gibNaechsten();
            }

            data = n.getInhalt();

            return data;
        }

        public void einfuegenVorne(T pInhalt)
        {
            Node<T> node = new Node<T>(pInhalt);
            node.setzeNaechster(head);
            head = node;
        }

        public T entfernenVorne()
        {
            T data;
            Node<T> node = head.gibNaechsten();

            if (head.gibNaechsten() == null)
            {
                return default;
            }

            data = node.getInhalt();
            head.setzeNaechster(node.gibNaechsten());

            return data;
        }

        public bool istLeer()
        {
            return (head == null) ? true : false;
        }

        public void ersetzten(int pIndex, T pInhalt)
        {
            if (pIndex < 0 || pIndex > anzahlElemente())
            {
                throw new IndexOutOfRangeException();
            }

            Node<T> temp = head;

            for (int i = 0; i < pIndex; i++)
            {
                temp = temp.gibNaechsten();
            }

            temp.setzteInhalt(pInhalt);
        }

        public T entfernen(int pIndex)
        {
            Node<T> temp = head, n;

            if (pIndex < 0 || pIndex > anzahlElemente())
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = 0; i < pIndex; i++)
            {
                temp = temp.gibNaechsten();
            }

            n = temp.gibNaechsten();
            temp.setzeNaechster(n.gibNaechsten());

            return temp;
        }

        public void ersetzen(T pInhalt, int pIndex)
        {
            if (pIndex < 0 || pIndex > anzahlElemente())
            {
                throw new IndexOutOfRangeException();
            }

            Node<T> node = head;

            for (int i = 0; i < pIndex; i++)
            {
                node = node.gibNaechsten();
                if (Equals(pInhalt))
                {
                    entfernen(i);
                }
            }
        }
    }
}
