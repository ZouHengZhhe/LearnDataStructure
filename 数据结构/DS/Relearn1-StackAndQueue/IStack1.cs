using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_StackAndQueue
{
    //栈的接口
    public interface IStack1<T>
    {
        int GetLength();    //求栈的长度
        bool IsEmpty();     //判断栈是否为空
        void Clear();       //清空操作
        void Push(T item);  //入栈操作
        void Pop();         //出栈操作
        T GetTop();         //取栈顶元素
    }
}
