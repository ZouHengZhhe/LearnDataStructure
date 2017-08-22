using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_StackAndQueue
{
    public class LinkStackNode<T>
    {
        private T data;                   //数据域
        private LinkStackNode<T> next;    //引用域

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public LinkStackNode<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        //构造
        public LinkStackNode(T val, LinkStackNode<T> n)
        {
            this.data = val;
            this.next = n;

        }


        public LinkStackNode(T val)
        {
            this.data = val;
            this.next = null;
        }

        public LinkStackNode(LinkStackNode<T> n)
        {
            this.data = default(T);
            this.next = n;
        }

        public LinkStackNode()
        {
            this.data = default(T);
            this.next = null;
        }

    }
}
