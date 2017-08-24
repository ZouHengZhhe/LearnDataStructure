using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_StackAndQueue
{
    //循环顺序队列类
    public class CSeqQueue1<T> : IQueue1<T>
    {
        private int maxsize;  //循环顺序队列的容量
        private T[] data;     //数组，用于存储循环顺序队列中的数据元素
        private int front;    //指示循环顺序队列的队头
        private int rear;     //指示循环顺序队列的队尾

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

        //队头属性
        public int Front
        {
            get { return front; }
        }

        //队尾属性
        public int Rear
        {
            get { return rear; }
        }

        //构造
        public CSeqQueue1(int size)
        {
            maxsize = size ;
            front = -1;
            rear = -1;
            data=new T[size];
        }

        //求循环顺序队列的长度
        public int GetLength()
        {
            return (rear - front + maxsize)%maxsize;
        }

        //清空循环顺序队列
        public void Clear()
        {
            rear = front = -1;
        }

        //判断循环顺序队列是否为空
        public bool IsEmpty()
        {
            if (rear==front)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //判断循环顺序队列是否为满
        public bool IsFull()
        {
            if ((rear+1)%maxsize==front)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //入队
        public void In(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("The queue is full,you can not add element to queue!");
                return;
            }

            rear = (rear + 1)%maxsize;
            data[rear] = item;

        }

        //出队
        public void Out()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty,you can not remove element!");
                return;
            }

            data[front]=default(T);
            front = (front + 1)%maxsize;

        }

        public T GetOut()
        {
            if(IsEmpty())
            {
                Console.WriteLine("The queue is empty,you can not remove element!");
                return default (T);
            }

            
            //data[front] = default(T);
            front = (front + 1) % maxsize;
            return data[front];
        }

        //获取队头数据元素
        public T GetFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty,you can not get the front element!");
                return default(T);
            }

            return data[front];
        }

    }
}
