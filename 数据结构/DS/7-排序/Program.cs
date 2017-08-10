using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_排序
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list=new List<int>() {16,13, 1, 1651, 64, 61, 311, 916, 1, 81, 9 };
            //MyInsertSort(list);
            //MyBubbleSort(list);
            //MySimpleSelectSort(list);
            //QuickSort(list,0,list.Count-1);
            MyQuickSort(list,0,list.Count-1);
            foreach (int temp in list)
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }

        //直接插入排序
        static void InsertSort(List<int> list )
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i]<list[i-1])
                {
                    int tmp = list[i];
                    int j = 0;
                    for (j = i - 1; j >= 0 && tmp < list[j]; --j)//次循环相当于把数组中的数不断往后移动
                    {
                        list[j + 1] = list[j];
                    }
                    list[j + 1] = tmp;
                }
            }
        }

        //自己写的直接插入排序
        static void MyInsertSort(List<int> list )
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i]<list[i-1])
                {
                    int temp = list[i];
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (temp < list[j])
                        {
                            list[j + 1] = list[j];
                            list[j] = temp;
                        }
                    }
                }
                
            }
        }

        //冒泡排序
        static void BubbleSort(List<int> list)
        {
            int tmp;
            for (int i = 0; i < list.Count; ++i)
            {
                for (int j = list.Count - 1; j >= i; --j)
                {
                    if (list[j + 1] < list[j])
                    {
                        tmp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = tmp;
                    }
                }
            }
        }

        //自己写的冒泡排序
        static void MyBubbleSort(List<int> list )
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1-i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
            
        }

        //简单选择排序
        static void SimpleSelectSort(List<int> list)
        {
            int tmp = 0;
            int t = 0;
            for (int i = 0; i < list.Count; ++i)
            {
                t = i;
            for (int j = i + 1; j <= list.Count; ++j)
                {
                    if (list[t] > list[j])
                    {
                        t = j;
                    }
                }
                tmp = list[i];
                list[i] = list[t];
                list[t] = tmp;
            }
        }

        //自己写的简单选择排序
        static void MySimpleSelectSort(List<int> list )
        {
            int t = 0;
            for (int i = 0; i < list.Count; i++)
            {
                t = i;
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[t]>list[j])
                    {
                        t = j;
                    }
                }
                int temp = list[i];
                list[i] = list[t];
                list[t] = temp;
            }
        }

        //快速排序
        static void QuickSort(List<int> list, int low, int high)
        {
            int i = low;
            int j = high;
            int tmp = list[low];
            while (low < high)
            {
                while ((low < high) && (list[high] >= tmp))
                {
                    --high;
                }
                list[low] = list[high];
                ++low;
                while ((low < high) && (list[low] <= tmp))
                {
                    ++low;
                }
                list[high] = list[low];
                --high;
            }
            list[low] = tmp;
            if (i < low - 1)
            {
                QuickSort(list, i, low - 1);
            }
            if (low + 1 < j)
            {
                QuickSort(list, low + 1, j);
            }
        }

        //自己写的快速排序
        static void MyQuickSort(List<int> list, int low, int high)
        {
            int i = low;
            int j = high;
            int temp = list[i];
            while (low<high)
            {
                while (low<high&&list[high]>=temp)
                {
                    high--;
                }
                list[low] = list[high];
                low++;
                while (low<high&&list[low]<=temp)
                {
                    low++;
                }
                list[high] = list[low];
            }
            list[low] = temp;

            //自身递归
            if (i<low-1)
            {
                MyQuickSort(list,i,low-1);
            }
            if (j>low+1)
            {
                MyQuickSort(list,low+1,j);
            }
        }
    }

}
