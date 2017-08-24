using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_Tree
{
    //二叉树的二叉链表的节点类
    public class Node<T>
    {
        private T data;
        private Node<T> lChild;
        private Node<T> rChild;

        //数据域属性
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        //左孩子引用域属性
        public Node<T> LChild
        {
            get { return lChild; }
            set { lChild = value; }
        }

        //右孩子引用域属性
        public Node<T> RChild
        {
            get { return rChild; }
            set { rChild = value; }
        }

        //构造
        public Node(T val, Node<T> l, Node<T> r)
        {
            this.data = val;
            this.lChild = l;
            this.rChild = r;
        }

        public Node( Node<T> l, Node<T> r)
        {
            this.data = default(T);
            this.lChild = l;
            this.rChild = r;
        }

        public Node(T val)
        {
            this.data = val;
            this.lChild = null;
            this.rChild = null;
        }

        public Node()
        {
            this.data = default(T);
            this.lChild = null;
            this.rChild = null;
        }

    }
}
