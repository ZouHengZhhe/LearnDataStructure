using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_StackAndQueue
{
    public class LinkQueueNode<T>
    {
        private T data;                  //数据域
        private LinkQueueNode<T> next;   //引用域

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public LinkQueueNode<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public LinkQueueNode(T item,LinkQueueNode<T> p)
        {
            this.data = item;
            this.next = p;
        }

        public LinkQueueNode(T item)
        {
            this.data = item;
            this.next = null;
        }
        public LinkQueueNode( LinkQueueNode<T> p)
        {
            this.data = default(T);
            this.next = p;
        }

        public LinkQueueNode()
        {
            this.data = default(T);
            this.next = null;
        }

    }
}
