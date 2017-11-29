using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure_单链表
{
    /// <summary>
    /// 单链表节点类
    /// </summary>
    public class Node<T>
    {
        private T data;
        private Node<T> next;

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public Node()
        {
            data = default(T);
            next = null;
        }

        public Node(T val)
        {
            data = val;
            next = null;
        }

        public Node(Node<T> p)
        {
            data = default(T);
            next = p;
        }

        public Node(T val, Node<T> p)
        {
            data = val;
            next = p;
        }
    }
}