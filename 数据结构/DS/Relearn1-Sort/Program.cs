using Relearn1_List;
using System;

namespace Relearn1_Sort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SeqList<int> list = new SeqList<int>(10);
            list.Append(42);
            list.Append(20);
            list.Append(17);
            list.Append(27);
            list.Append(13);
            list.Append(8);
            list.Append(17);
            list.Append(48);

            //InsertSort(list);//直接插入排序测试
            //BubbleSort(list);//冒泡排序测试
            //SimpleSelectSort(list);//简单选择排序
            QuickSort(list, 0, list.GetLength() - 1);

            for (int i = 0; i < list.GetLength(); i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }

        //直接插入排序
        //情况最好：list中的记录已全部排好序，时间复杂度O(n)
        //情况最坏：list中记录是反序的，时间复杂度O(n^2)
        //随机：list中的记录的排列是随机的，时间复杂度在O(n)~~O(n^2)之间
        private static void InsertSort(SeqList<int> list)
        {
            int len = list.GetLength();
            for (int i = 1; i < len; i++)
            {
                if (list[i] < list[i - 1])
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
        //情况最好：记录已全部排好序，时间复杂度O(n)
        //情况最坏：list中记录是反序的，时间复杂度O(n^2)
        private static void BubbleSort(SeqList<int> list)
        {
            int len = list.GetLength();
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - 1 - i; j++)
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
        //简单选择排序算法的时间复杂度为O(n^2 )。
        private static void SimpleSelectSort(SeqList<int> list)
        {
            int len = list.GetLength();
            int t = 0;
            for (int i = 0; i < len; i++)
            {
                t = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (list[t] > list[j])
                    {
                        t = j;//找出list中最小的数，并记录其索引位置
                    }
                }
                int temp = list[i];
                list[i] = list[t];
                list[t] = temp;
            }
        }

        //快速排序
        //最好情况下快速排序的时间复杂度为O（nlog 2 n）
        //在最坏情况下快速排序算法的时间复杂度为O(n^2 )
        //快速排序算法在一般情况下的时间复杂度为O（nlog 2 n）
        private static void QuickSort(SeqList<int> list, int low, int high)
        {
            int i = low;
            int j = high;
            int temp = list[low];
            while (low < high)
            {
                while (low < high && temp <= list[high])
                {
                    high--;
                }
                list[low] = list[high];
                //low++;
                while (low < high && temp > list[low])
                {
                    low++;
                }
                list[high] = list[low];
                //high--;
            }
            list[low] = temp;//到这一步，一次划分完成
            if (i < low - 1)
            {
                QuickSort(list, i, low - 1);
            }
            if (low + 1 < j)
            {
                QuickSort(list, low + 1, j);
            }
        }

        //堆排序=======================================================================

        //建最大堆
        private static void CreateHeap(SeqList<int> list, int low, int high)
        {
            if (low < high && high <= list.Last)
            {
                int j = 0;
                int temp = 0;
                int k = 0;
                for (int i = high / 2; i >= low; i--)
                {
                    k = i;
                    j = 2 * k + 1;
                    temp = list[i];
                    while (j <= high)
                    {
                        if (j < high && j + 1 <= high && list[j] < list[j + 1])
                        {
                            j++;
                        }
                        if (temp < list[j])
                        {
                            list[k] = list[j];
                            k = j;
                            j = 2 * k + 1;
                        }
                        else
                        {
                            j = high + 1;
                        }
                    }
                    list[k] = temp;
                }
            }
        }

        //堆排序=======================================================================
    }
}