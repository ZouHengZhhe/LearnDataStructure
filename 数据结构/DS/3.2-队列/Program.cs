using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3._1_栈;

namespace _3._2_队列
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 顺序循环队列
            //CSeqQueue<int> queue1=new CSeqQueue<int>(5);
            //queue1.In(1);
            //queue1.In(2);
            //queue1.In(3);

            //queue1.Out();
            //queue1.Out();
            //queue1.Out();

            //queue1.In(0);
            //queue1.In(1);
            //queue1.In(2);

            //queue1.Out();
            //queue1.Out();
            //queue1.Out();

            //queue1.In(3);
            //queue1.In(1);
            //queue1.In(2);

            //Console.WriteLine("头元素:"+queue1.GetFront());
            //Console.WriteLine("队头："+queue1.Front);
            //Console.WriteLine("队尾："+queue1.Rear);
            //Console.WriteLine("队列长度:"+queue1.GetLength());

            //Console.ReadKey();
            #endregion

            #region 链队列

            SeqStack<char> s = new SeqStack<char>(50);
            CSeqQueue<char> q = new CSeqQueue<char>(50);
            Console.WriteLine("请输入字符串用于判断您输入的字符串是否是回文字符!(按回车键结束)");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                s.Push(str[i]);
                q.In(str[i]);
            }

            while (!s.IsEmpty() && !q.IsEmpty())
            {
                if (s.Pop() != q.Out())
                {
                    break;
                }
            }

            if (!s.IsEmpty() || !q.IsEmpty())
            {
                Console.WriteLine("这不是回文！");
            }
            else
            {
                Console.WriteLine("这是回文！");
            }

            Console.ReadKey();
            

            #endregion

        }
    }
}
