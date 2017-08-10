using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 顺序表;

namespace _1_单链表
{
    public class LinkList<T> : IListDS<T>
    {
        private Node<T> head; //单链表的头引用

        public Node<T> Head
        {
            get { return head; }
            set { head = value; }
        }

        public LinkList()
        {
            head = null;
        }

        //求单链表的长度,T(n)=O(n)
        public int GetLength()
        {
            Node<T> p = head;
            int len = 0;
            while (p != null)
            {
                ++len;
                p = p.Next;
            }
            return len;
        }

        //清空单链表
        public void Clear()
        {
            head = null;
        }

        //判断单链表是否为空
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //在单链表的末尾添加新元素
        public void Append(T item)
        {
            Node<T> q = new Node<T>(item);
            Node<T> p = new Node<T>();
            if (head == null)
            {
                head = q;
                return;
            }
            p = head;
            while (p.Next != null)
            {
                p = p.Next;
            }
            p.Next = q;
        }

        //删除单链表的第i个结点
        public T Delete(int i)
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("Link is empty or Position is error!");
                return default(T);
            }
            Node<T> q = new Node<T>();
            if (i == 1)
            {
                q = head;
                head = head.Next;
                return q.Data;
            }
            Node<T> p = head;
            int j = 1;
            while (p.Next != null && j < i)
            {
                ++j;
                q = p;
                p = p.Next;
            }
            if (j == i)
            {
                q.Next = p.Next;
                return p.Data;
            }
            else
            {
                Console.WriteLine("The ith node is not exist!");
                return default(T);
            }
        }

        //获得单链表的第i个数据元素
        public T GetElem(int i)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return default(T);
            }
            Node<T> p = new Node<T>();
            p = head;
            int j = 1;
            while (p.Next != null && j < i)
            {
                ++j;
                p = p.Next;
            }
            if (j == i)
            {
                return p.Data;
            }
            else
            {
                Console.WriteLine("The ith node is not exist!");
                return default(T);
            }
        }

        //在单链表的第i个结点的位置前插入一个值为item的结点
        public void Insert(T item, int i)
        {
            if (IsEmpty() || i < 1)
            {
                Console.WriteLine(" List is empty or Position is error! ");
                return;
            }
            if (i == 1)
            {
                Node<T> q = new Node<T>(item);
                q.Next = head;
                head = q;
                return;
            }
            Node<T> p = head;
            Node<T> r = new Node<T>();
            int j = 1;
            while (p.Next != null && j < i)
            {
                r = p;
                p = p.Next;
                ++j;
            }
            if (j == i)
            {
                Node<T> q = new Node<T>(item);
                q.Next = p;
                r.Next = q;
            }
        }

        //在单链表的第i个结点的位置后插入一个值为item的结点
        public void InsertPost(T item, int i)
        {
            if (IsEmpty() || i < 1)
            {
                Console.WriteLine(" List is empty or Position is error! ");
                return;
            }
            if (i == 1)
            {
                Node<T> q = new Node<T>(item);
                q.Next = head.Next;
                head.Next = q;
                return;
            }
            Node<T> p = head;
            int j = 1;
            while (p != null && j < i)
            {
                p = p.Next;
                ++j;
            }
            if (j == i)
            {
                Node<T> q = new Node<T>(item);
                q.Next = p.Next;
                p.Next = q;
            }
        }

        //在单链表中查找值为value的结点
        public int Locate(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return -1;
            }
            Node<T> p = new Node<T>();
            p = head;
            int i = 1;
            while (!p.Data.Equals(value) && p.Next != null)
            {
                p = p.Next;
                ++i;
            }
            return i;
        }

        public void Reverse()
        {
            Node<T> p = head.Next;
            Node<T> p = head.Next;
            Node<T> q = new Node<T>();
            head.Next = null;
            while (p != null)
            {
                q = p; p = p.Next;
                q.Next = head.Next;
                head.Next = q;
            }
        }

        //在头部插入结点建立单链表的算法
        LinkList<int> CreateLListHead()
        {
            int d;
            LinkList<int> L = new LinkList<int>();
            d = Int32.Parse(Console.ReadLine());

            while (d != -1)
            {
                Node<int> p = new Node<int>(d);
                p.Next = L.Head;
                L.Head = p;
                d = Int32.Parse(Console.ReadLine());
            }
            return L;
        }

        //在尾部插入结点建立单链表的算法如下：
        LinkList<int> CreateListTail()
        {
            Node<int> R = new Node<int>();
            int d;
            LinkList<int> L = new LinkList<int>();
            R = L.Head;
            d = Int32.Parse(Console.ReadLine());
            while (d != -1)
            {
                Node<int> p = new Node<int>(d);
                if (L.Head == null)
                {
                    L.Head = p;
                }
                else
                {
                    R.Next = p;
                }
                R = p;
                d = Int32.Parse(Console.ReadLine());
            }
            if (R != null)
            {
                R.Next = null;
            }
            return L;
        }

        //存储整数的单链表的倒置的算法实现如下：
        public void ReversLinkList(LinkList<T> H)
        {
            Node<T> p = H.Next;
            Node<T> q = new Node<T>();
            H.Next = null;
            while (p != null)
            {
                q = p;
                p = p.Next;
                q.Next = H.Next;
                H.Next = q;
            }
        }


    }
}
