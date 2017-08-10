using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_栈
{
    public class LinkStack<T>:IStack<T>
    {
        private Node<T> top; //栈顶指示器
        private int num;     //栈中结点的个数

        //栈顶指示器属性
        public Node<T> Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }
        //元素个数属性
        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }

        //构造器
        public LinkStack()
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
            if ((top == null) && (num == 0))
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
            Node<T> q = new Node<T>(item);

            if (top == null)
            {
                top = q;
            }
            else
            {
                q.Next = top;
                top = q;
            }
            ++num;
        }

        //出栈
        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }
            Node<T> p = top;
            top = top.Next;
            --num;
            return p.Data;
        }
        //获取栈顶结点的值
        public T GetTop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }
            return top.Data;
        }


    }
}
