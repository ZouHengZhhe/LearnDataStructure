using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_栈
{
    //顺序栈类
    public class SeqStack<T>:IStack<T>
    {
        private int maxsize;  //顺序栈的容量
        private T[] data;     //数组，用于存储顺序栈中的数据元素
        private int top;      //指示顺序栈的栈顶(类似于最大索引)

        //索引器
        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        //容量属性
        public int Maxsize
        {
            get { return maxsize; }
            set { maxsize = value; }
        }

        //栈顶属性（只读）
        public int Top
        {
            get { return top; }
        }

        //构造函数
        public SeqStack(int size)
        {
            data=new T[size];
            maxsize = size;
            top = -1;
        }

        //求栈的长度
        public int GetLength()
        {
            return top + 1;
        }

        //清空顺序栈
        public void Clear()
        {
            top = -1;
        }

        //判断顺序栈是否为空
        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //判断顺序栈是否为满
        public bool IsFull()
        {
            if (top == maxsize - 1)
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
            if (IsFull())
            {
                Console.WriteLine("Stack is full");
                return;
            }
            data[++top] = item;
        }

        //出栈
        public T Pop()
        {
            T temp=default(T);
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return temp;
            }

            temp = data[top];
            --top;
            return temp;
        }

        //获取栈顶数据元素
        public T GetTop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }
            return data[top];
        }

    }
}
