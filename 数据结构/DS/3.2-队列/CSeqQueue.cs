using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_队列
{
    /// <summary>
    /// 顺序循环队列
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CSeqQueue<T> : IQueue<T>
    {
        private int maxsize;  //循环顺序队列的容量
        private T[] data;     //数组，用于存储循环顺序队列中的数据元素
        private int front;    //指示循环顺序队列的队头
        private int rear;     //指示循环顺序队列的队尾

        //索引器
        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] =value ; }
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
            set { front = value; }
        }

        //队尾属性
        public int Rear
        {

            get { return rear; }
            set { rear = value; }
        }

        //构造
        public CSeqQueue(int size)
        {
            data=new T[size];
            maxsize = size;
            front = rear = -1;
        }

        /// <summary>
        /// 求循环顺序道路的长度
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            return (rear - front + maxsize) % maxsize;
        }

        /// <summary>
        /// 清空循环队列
        /// </summary>
        public void Clear()
        {
            front = rear = -1;
        }

        /// <summary>
        /// 判断循环顺序队列是否为空     
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (front == rear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 判断循环顺序队列是否为满
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 入队
        /// </summary>
        /// <param name="item"></param>
        public void In(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
                return;
            }
            if (rear == maxsize - 1)
            {
                rear = 0;
            }
            else
            {
                rear++;
            }
            data[rear] = item;
        }

        /// <summary>
        /// 出队
        /// </summary>
        /// <returns></returns>
        public T Out()
        {
            T tmp = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return tmp;
            }
            if (front==maxsize-1)
            {
                front = 0;
            }
            else
            {
                front++;
            }
            tmp = data[front];
            return tmp;
        }

        /// <summary>
        /// 获取队头数据元素
        /// </summary>
        /// <returns></returns>
        public T GetFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
            return data[front + 1]; 
        }


        

       

    }
}
