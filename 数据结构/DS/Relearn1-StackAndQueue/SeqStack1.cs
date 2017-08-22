using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_StackAndQueue
{
    //顺序栈类
    public class SeqStack1<T>:IStack1<T>
    {
        private int maxsize;   //顺序栈的容量
        private T[] data;      //数组，用于存储顺序栈中的数据元素
        private int top;       //指示顺序栈的栈顶

        //索引器
        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        //容量属性
        public int Maxsize
        {
            get { return maxsize;}
            set { maxsize = value; }
        }

        //栈顶属性
        public int Top
        {
            get { return top; }
            set { top = value; }
        }

        //构造
        public SeqStack1(int size)
        {
            maxsize = size;
            data=new T[size];
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
            if (top==-1)
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
            if (top==maxsize-1)
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
                Console.WriteLine("The stack is full,you can not add a element to stack");
                return;
            }

            data[top+1] = item;
            top++;

        }

        //出栈
        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty,you can not to remove a element from stack!");
                return;
            }

            top--;

        }

        //获取栈顶数据元素
        public T GetTop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty , you can not get the top element!");
                return default(T);
            }
            return data[top];
        }

     

    }
}
