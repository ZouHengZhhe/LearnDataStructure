using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_List
{
    //双向链表的类
    public class DbNode<T>
    {
        private T data;          //数据域
        private DbNode<T> prev;  //前驱引用域
        private DbNode<T> next;  //后继引用域

        //构造
        public DbNode(T val,DbNode<T> p )
        {
            data = val;
            next = p;
        }

        public DbNode(T val)
        {
            data = val;
            next = null;
        }

        public DbNode(DbNode<T> p)
        {
            data=default(T);
            next = p;
        }

        public DbNode()
        {
            data=default(T);
            next = null;
        }

        //数据域属性
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        //前驱节点属性
        public DbNode<T> Prev
        {
            get { return prev; }
            set { prev = value; }
        }

        //后继节点属性
        public DbNode<T> Next
        {
            get { return next;}
            set { next = value; }
        }

    }
}
