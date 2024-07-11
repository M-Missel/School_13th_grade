using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_School_Solution
{
    class LinkedList<T>
    {
        private Node<T> head;

        public LinkedList() {
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
    }
}
