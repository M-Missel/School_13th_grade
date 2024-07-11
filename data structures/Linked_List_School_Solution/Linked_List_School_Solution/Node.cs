using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_School_Solution
{
    class Node<T>
    {
        private T data;
        private Node<T> nextNode;

        public Node(T pInhalt)
        {
            this.data = pInhalt;
            nextNode = null;
        }

        public void setzeNaechster(Node<T> pKn)
        {
            this.nextNode = pKn;
        }

        public Node<T> gibNaechsten()
        {
            return this.nextNode;
        }

        public T getInhalt()
        {
            return this.data;
        }
    }
}
