using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._4_二叉链表存储结构
{
    //二叉树节点类
    public class Node<T>
    {
        private T data;          //数据域
        private Node<T> lChild;  //左孩子
        private Node<T> rChild;  //右孩子

        //构造
        public Node(T val,Node<T> lp,Node<T> rp  )
        {
            this.data = val;
            this.lChild = lp;
            this.rChild = rp;
        }

        public Node(Node<T> lp, Node<T> rp)
        {
            this.data=default(T);
            this.lChild = lp;
            this.rChild = rp;
        }

        public Node(T val)
        {
            this.data = val;
            this.lChild = null;
            this.rChild = null;
        }

        //数据属性
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        //左孩子属性
        public Node<T> LChild
        {
            get { return lChild;}
            set { lChild = value; }
        }

        //右孩子属性
        public Node<T> RChild
        {
            get { return rChild; }
            set { rChild = value; }
        }

    }
}
