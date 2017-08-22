using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_StackAndQueue
{
    public interface IQueue1<T>
    {
        int GetLength();  //求队列的长度
        bool IsEmpty();   //判断队列是否为空
        void Clear();     //清空队列
        void In(T item);  //入队
        void Out();       //出队
        T GetFront();     //取队头元素
    }
}
