using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_List
{
    //线性表接口类
    public interface IListDS<T>
    {
        int GetLength();                  //求长度
        void Clear();                     //清空操作
        bool IsEmpty();                   //判断线性表是否为空
        void  Append(T item);             //附加操作(在线性表的末尾添加元素)
        void Insert(T item,int index);    //插入操作
        void Delete(int  index);   //删除操作
        T GetElem(int index);             //取表元(根据索引，取得表中的元素)
        int Locate(T item);               //按值查找(根据元素值，得到该元素在线性表中的索引)
    }
}
