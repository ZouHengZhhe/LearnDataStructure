using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_StackAndQueue
{
    public class LinkStack1<T>:IStack1<T>
    {
        private LinkStackNode<T> top;  //栈顶指示器
        private int num;               //栈中节点的个数

        //栈顶指示器属性
        public LinkStackNode<T> Top
        {
            get { return top; }
            set { top = value; }
        }

        //元素个数属性
        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        //构造
        public LinkStack1()
        {
            top = null;
            num = 0;

        }

        //求链栈的长度
        public int GetLength()
        {
            return num;
        }

        //清空链栈
        public void Clear()
        {
            top = null;
            num = 0;
        }

        //判断链栈是否为空
        public bool IsEmpty()
        {
            if (num==0&&top==null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //入栈
        public void Push(T item)
        {
            LinkStackNode<T> p=new LinkStackNode<T>(item);

            if (top==null)
            {
                top = p;
            }
            else
            {
                p.Next = top;
                top = p;
            }
            num++;
        }

        //出栈
        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The LinkStack is empty,you can not remove element!");
                return;
            }

            LinkStackNode<T> p=new LinkStackNode<T>();
            p = top.Next;
            top = p;
            num--;

        }

        //获取栈顶顶点的值
        public T GetTop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The LinkStack is empty,you can not get the top element!");
                return default(T);
            }

            return top.Data;

        }

        //进制转换，10进制数转换为8进制数
        public int Conversion(int n)
        {
            LinkStack1<int> a=new LinkStack1<int>();
            int i = 0;
            while (n != 0)
            {
                i = n % 8;
                n = n / 8;
                a.Push(i);
            }
            int num = a.Num;
            int temp = 0;
            LinkStackNode<int> p = a.Top;
            while (p!=null&&num-1>=0)
            {
                temp+=p.Data* (int)Math.Pow(10,num-1);
                p = p.Next;
                num--;
            }
            return temp;
        }

    }
}
