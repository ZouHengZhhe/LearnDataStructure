using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_List
{
    //单链表节点类
    public class Node1<T>
    {
        private T data;        //数据域
        private Node1<T> next;  //引用域

        //数据域属性
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        //引用域属性
        public Node1<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        //构造
        public Node1(T val,Node1<T> p )
        {
            this.data = val;
            this.next = p;
        }

        public Node1(T val)
        {
            this.data = val;
            this.next = null;
        }

        public Node1(Node1<T> p)
        {
            this.data=default(T);
            this.next = p;
        }

        public Node1()
        {
            this.data=default(T);
            this.next = null;
        }

    }
}
