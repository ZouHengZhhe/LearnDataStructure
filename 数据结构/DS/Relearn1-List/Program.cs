using System;
using System.Collections.Generic;
using System.Linq;
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

            LinkList1<int> a = new LinkList1<int>();
            a.Append(1);
            a.Append(2);
            a.Append(3);
            a.Append(4);
            a.Append(5);
            //a.Append(6);

            a.ReversLinkList();//头插法倒置
            Console.WriteLine(a.GetLength());
            Console.WriteLine(a.GetElem(2));
            Console.ReadKey();

        }
    }
}
