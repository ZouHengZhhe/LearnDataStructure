using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_队列
{
    /// <summary>
    /// 链队列
    /// </summary>
    public class LinkQueue<T> : IQueue<T>
    {
        private Node<T> front;  //队列头指示器
        private Node<T> rear;   //队列尾指示器
        private int num;        //队列节点个数

        //队头属性
        public Node<T> Front
        {
            get { return front; }
            set { front = value; }
        }

        //队尾属性
        public Node<T> Rear
        {
            get { return rear; }
            set { rear=value; }
        }

        //队列节点个数属性
        public int Num
        {
            get { return num; }
            set { num=value; }
        }

        //构造
        public LinkQueue()
        {
            front = rear = null;
            num = 0;
        }

        /// <summary>
        /// 求链队列的长度
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            return num;
        }

        /// <summary>
        /// 清空链队列
        /// </summary>
        public void Clear()
        {
            front = rear = null;
            num = 0;
        }

        /// <summary>
        /// 判断链队列是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if ((front == rear) && (num == 0))
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
            Node<T> q = new Node<T>(item);
            if (rear == null) //如果队列中没有元素
            {
                rear = q;
            }
            else
            {
                rear.Next = q;
                rear = q;
            }
            num++;
        }

        /// <summary>
        /// 出队
        /// </summary>
        /// <returns></returns>
        public T Out()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }

            Node<T> p = front;
            front = front.Next;
            
            num--;
            return p.Data;
        }

        /// <summary>
        /// 获取链队列头结点的值
        /// </summary>
        /// <returns></returns>
        public T GetFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
            return front.Data;
        }
    }
}
