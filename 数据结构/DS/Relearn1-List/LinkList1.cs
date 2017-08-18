﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_List
{
    //单链表类
    public class LinkList1<T> : IListDS1<T>
    {
        private Node1<T> head;  //头引用

        //头引用属性
        public Node1<T> Head
        {
            get { return head; }
            set { head = value; }
        }

        //构造器
        public LinkList1()
        {
            head = null;
        }

        //求单链表的长度(最大索引+1)
        public int GetLength()
        {
            Node1<T> p = head;
            int len = 0;

            while (p.Next != null)
            {
                p = p.Next;
                len++;
            }
            return len + 1;

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

            return false;
        }

        //在单链表的末尾添加新元素
        public void Append(T item)
        {
            Node1<T> p = new Node1<T>(item);
            Node1<T> q = new Node1<T>();

            if (head == null)
            {
                head = p;
                return;
            }

            q = head;
            while (q.Next != null)
            {
                q = q.Next;
            }

            q.Next = p;

        }

        //在单链表的索引为i的结点的位置前插入一个值为item的结点
        public void Insert(T item, int index)
        {
            //单链表为空，切插入元素位置不为0
            if (IsEmpty() && index != 0)
            {
                Console.WriteLine("The LinkList is empty,but the position you want to insert is not head,it is not allow!");
                return;
            }

            if (index < 0)
            {
                Console.WriteLine("The position you want to insert is smaller than the head , it is not allow!(The index you input must be bigger than 0)");
                return;
            }
            else if (index > GetLength() - 1)
            {
                Console.WriteLine("The position you want to insert is bigger than this LinkList's length,you have to let the index littler than this LinkList's length");
                return;
            }

            //插入单链表头部
            if (index == 0)
            {
                Node1<T> p = head;
                head.Data = item;
                head.Next = p;
                return;
            }

            //不插入单链表头部
            int i = 0;
            Node1<T> q = head;
            Node1<T> r = new Node1<T>();

            while (q.Next != null && i < index)
            {
                r = q;
                q = q.Next;
                i++;
            }

            if (i == index)
            {
                Node1<T> k = new Node1<T>(item);
                k.Next = q;
                r.Next = k;
            }

        }

        //在单链表的索引为i的结点的位置后插入一个值为item的结点
        public void InsertBehind(T item, int index)
        {

        }

        //删除单链表的第i个结点
        public void Delete(int index)
        {
            if (IsEmpty())
            {
                Console.WriteLine("The LinkList is empty,you can not do this!");
                return;
            }

            if (index < 0)
            {
                Console.WriteLine("The position you want to delete is littler than head,you can not do this!(You have to make the index bigger than 0)");
                return;
            }
            else if (index > GetLength())
            {
                Console.WriteLine("The position you want to delete is bigger than this LinkList's length,you can not do this!");
                return;
            }

            int i = 0;
            Node1<T> p = head;
            Node1<T> r = new Node1<T>();

            while (p.Next != null && i < index)
            {
                r = p;
                p = p.Next;
                i++;
            }

            if (i == index && index != 0)
            {
                if (index == 0)
                {
                    head = head.Next;
                }
                else if (index == GetLength() - 1)
                {
                    r.Next = null;
                }
                else
                {
                    r.Next = p.Next;
                }
            }

        }

        //获得单链表的第i个数据元素
        public T GetElem(int index)
        {
            if (IsEmpty())
            {
                Console.WriteLine("The LinkList is empty,you can not get any element!");
                return default(T);
            }

            if (index < 0)
            {
                Console.WriteLine("The element's position want to get is littler than head,you can not do this! ");
                return default(T);
            }
            else if (index > GetLength() - 1)
            {
                Console.WriteLine("The element's position want to get is bigger than this LinkList's length,you can not do this!");
                return default(T);
            }

            Node1<T> p = head;
            int len = 0;
            while (p.Next != null && len < index)
            {
                p = p.Next;
                len++;
            }
            return p.Data;

        }

        //在单链表中查找值为value的结点
        public int Locate(T item)
        {
            if (IsEmpty())
            {
                Console.WriteLine("The LinkList is empty,you can not do this!");
                return -1;
            }

            Node1<T> p = head;
            int len = 0;

            while (p.Next != null && !p.Data.Equals(item))
            {

                p = p.Next;
                len++;
            }
            if (!p.Data.Equals(item) && len == GetLength() - 1)
            {
                return -1;
            }
            return len;

        }

        //倒置，头插法
        public void ReversLinkList()
        {
            #region MyMethod
            //if (IsEmpty())
            //{
            //    Console.WriteLine("The LinkList is empty,you can not do this!");
            //    return;
            //}
            //else if (GetLength() == 1)
            //{
            //    Console.WriteLine("The LinkList just has one element,it do not need to revers!");
            //    return;
            //}
            //else if (GetLength() == 2)
            //{
            //    Node1<T> k = head.Next;
            //    head.Next = null;
            //    k.Next = head;
            //    head = k;
            //    return;
            //}


            //Node1<T> p = head.Next;
            //Node1<T> q = new Node1<T>();
            //head.Next = null;
            //int len = 0;
            //while (p.Next != null)
            //{
            //    q = p;
            //    p = p.Next;
            //    q.Next = head;
            //    head = q;
            //    len++;
            //    if (p.Next == null)
            //    {
            //        p.Next = head;
            //        head = p;
            //        break;
            //    }
            //}
            #endregion

            #region TheMethodInBook

            if (IsEmpty())
            {
                Console.WriteLine("The LinkList is empty,you can not do this!");
                return;
            }

            Node1<T> p = head.Next;
            Node1<T> q = new Node1<T>();
            head.Next = null;
            int len = 0;
            while (p != null)
            {
                q = p;
                p = p.Next;
                q.Next = head;
                head = q;
            }

            #endregion
        }

    

    }
}
