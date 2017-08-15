using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_队列
{
    public class Node<T>
    {
        private T data;       //数据域
        private Node<T> next; //引用域

        //构造
        public Node(T val, Node<T> p)
        {
            this.data = val;
            this.next = p;
        }

        public Node(T val)
        {
            this.data = val;
            this.next = null;
        }

        public Node(Node<T> p )
        {
            this.data=default(T);
            this.next = p;
        }

        public Node()
        {
            this.data=default(T);
            this.next = null;
        }

        //数据域属性
        public T Data
        {
            get { return data; }
            set { data=value; }
        }

        //引用域属性
        public Node<T> Next
        {
            get { return next; }

            set { next=value; }
        }
    }
}
