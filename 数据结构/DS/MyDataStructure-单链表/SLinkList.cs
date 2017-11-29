using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure_单链表
{
    public class SLinkList<T> : IListDS<T>
    {
        private Node<T> head;

        public Node<T> Head
        {
            get { return head; }
            set { head = value; }
        }

        //构造
        public SLinkList()
        {
            head = null;
        }

        /// <summary>
        /// 在单链表末尾添加元素
        /// </summary>
        /// <param name="item"></param>
        public void Append(T item)
        {
            Node<T> p = new Node<T>(item);
            if (head == null)
            {
                head = p;
                return;
            }
            else
            {
                p = head;
                while (p.Next != null)
                {
                    p = p.Next;
                }
                Node<T> q = new Node<T>(item);
                p.Next = q;
                return;
            }
        }

        public void Clear()
        {
        }

        public void Delete(int index)
        {
        }

        public T GetElement(int index)
        {
        }

        //求单链表的长度
        public int GetLength()
        {
            int len = 0;
            Node<T> p = head;
            if (head == null)
            {
                return 0;
            }
            else
            {
                while (p != null)
                {
                    len++;
                    p = p.Next;
                }
                return len;
            }
        }

        public void Insert(T item, int index)
        {
        }

        public bool IsEmpty()
        {
            if (head == null) { return true; }
            else { return false; }
        }

        public int Locate(T item)
        {
        }
    }
}