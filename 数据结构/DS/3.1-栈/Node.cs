using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_栈
{
    //链栈节点类
    public class Node<T>
    {
        private T data;//数据域
        private Node<T> next;  //引用域

        #region 构造函数
        public Node(T val, Node<T> p)
        {
            data = val;
            next = p;
        }

        public Node(Node<T> p)
        {
            next = p;
        }

        public Node(T val)
        {
            data = val;
        }

        public Node()
        {
            data=default(T);
            next = null;
        }
        #endregion

        //数据域属性
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        //引用域属性
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

    }
}
