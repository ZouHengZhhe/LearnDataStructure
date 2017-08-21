using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ////顺序表测试
            //SeqList<int> a=new SeqList<int>(3);
            //SeqList<int> b=new SeqList<int>(4);
            //SeqList<int> c=new SeqList<int>(4);
            //a.Append(1);
            //a.Append(3);
            //a.Append(5);
            //b.Append(2);
            //b.Append(4);
            //b.Append(4);
            //b.Append(8);

            //c=c.Purge(b);
            //for (int i = 0; i < c.GetLength(); i++)
            //{
            //    Console.WriteLine(c[i]);
            //}

            //Console.ReadKey();

            //验证单链表倒置
            //LinkList1<int> a = new LinkList1<int>();
            //a.Append(1);
            //a.Append(2);
            //a.Append(3);
            //a.Append(4);
            //a.Append(5);
            ////a.Append(6);

            //a.ReversLinkList();//头插法倒置
            //for (int i = 0; i < a.GetLength(); i++)
            //{
            //    Console.WriteLine("C中的第{0}个元素为：{1}", i, a.GetElem(i));
            //}

            //验证单链表合并
            //LinkList1<int> a = new LinkList1<int>();
            //LinkList1<int> b = new LinkList1<int>();
            //LinkList1<int> c = new LinkList1<int>();
            //a.Append(1);
            //a.Append(3);
            //a.Append(5);
            //a.Append(7);
            //b.Append(2);
            //b.Append(4);
            //b.Append(6);
            //b.Append(8);
            //b.Append(10);

            //c = c.Merge(a, b);
            //int len = c.GetLength();
            //Console.WriteLine(len);
            //for (int i = 0; i < len; i++)
            //{
            //    Console.WriteLine("C中的第{0}个元素为：{1}", i, c.GetElem(i));
            //}


            //验证删除单链表中相同值的节点(未完成)
            //LinkList1<int> a=new LinkList1<int>();
            //a.Append(1);
            //a.Append(2);
            //a.Append(1);
            //a.Append(3);
            //a.Append(1);
            //a.Append(4);

            //a=a.Purge(a);
            //int len = a.GetLength();
            //for (int i = 0; i < len; i++)
            //{
            //    Console.WriteLine("C中的第{0}个元素为：{1}", i, a.GetElem(i));
            //}

            Console.ReadKey();

        }
    }
}
