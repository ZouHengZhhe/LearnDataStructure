using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_StackAndQueue
{
    public class LinkQueue1<T> : IQueue1<T>
    {
        private LinkQueueNode<T> front;  //队列头指示器
        private LinkQueueNode<T> rear;   //队列尾指示器
        private int num;                 //队列节点个数

        public LinkQueueNode<T> Front
        {
            get { return front; }
            set { front = value; }
        }

        public LinkQueueNode<T> Rear
        {
            get { return rear; }
            set { rear = value; }
        }

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public LinkQueue1()
        {
            front = rear = null;
            num = 0;
        }

        //求链队列的长度
        public int GetLength()
        {
            return num;
        }

        //清空链队列
        public void Clear()
        {
            front = rear = null;
            num = 0;
        }

        //判断链队列是否为空
        public bool IsEmpty()
        {
            if (num == 0 && front == rear)
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
            LinkQueueNode<T> p = new LinkQueueNode<T>(item);

            if (IsEmpty())
            {
                rear = p;
                num++;
                return;
            }

            rear.Next = p;
            rear = p;
            num++;

        }

        //出队
        public void Out()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty , you can not remove element!");
                return;
            }

            LinkQueueNode<T> p=new LinkQueueNode<T>();
            p = front.Next;
            front = p;
            num--;
            if (front==null)
            {
                rear = null;
            }

        }

        //获取链队列头结点的值
        public T GetFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty,you can not get the front element!");
                return default(T);
            }

            return front.Data;

        }

    }
}
