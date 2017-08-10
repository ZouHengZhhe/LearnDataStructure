using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 顺序表
{
    /// <summary>
    /// 线性表接口类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IListDS<T>
    {
        int GetLength();                //求长度
        void Clear();                   //清空操作
        bool IsEmpty();                 //判断线性表是否为空
        void Append(T item);            //附加操作
        void Insert(T item, int i);     //插入操作
        T Delete(int i);                //删除操作
        T GetElem(int i);               //取表元（根据索引，取到表中的元素）
        int Locate(T value);            //按值查找
        void Reverse();                 //倒置操作
    }
}
