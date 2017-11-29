using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure
{
    public interface IListDS<T>
    {
        int GetLength();                       //求线性表的长度

        void Clear();                             //清空线性表

        bool IsEmpty();                        //判断线性表是否为空

        void Append(T item);              //添加，在线性表的末尾添加元素

        void Insert(T item, int index);  //插入操作(在指定的索引处，插入值)

        void Delete(int index);            //删除操作（删除指定索引处的值）

        T GetElement(int index);         //获取线性表元素（根据索引，得到该索引处的元素）

        int Locate(T item);                   //按值查找,定位（根据给定的值，查找该值在线性表中的索引）
    }
}