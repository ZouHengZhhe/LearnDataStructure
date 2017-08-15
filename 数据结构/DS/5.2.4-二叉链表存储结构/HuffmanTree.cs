using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._4_二叉链表存储结构
{
    //哈夫曼树类
    public class HuffmanTree
    {
        private HuffmanNode[] data; //结点数组
        private int leafNum;        //叶子结点数目

        //索引器
        public HuffmanNode this[int index]
        {
            get { return this.data[index]; }
            set { this.data[index] = value; }
        }

        //叶子结点数目属性
        public int LeafNum
        {
            get { return leafNum; }
            set { leafNum = value; }
        }

        //构造
        public HuffmanTree(int n)
        {
            data = new HuffmanNode[2 * n - 1];
            leafNum = n;
        }

        //创建哈夫曼树
        public void Create()
        {
            int max1, max2;
            int tmp1, tmp2;

            //输入n个叶子结点的权值
            for (int i = 0; i < this.leafNum; i++)
            {
                data[i].Weight = Console.Read();
            }

            //处理 n 个叶子结点，建立哈夫曼树
            for (int i = 0; i < this.leafNum - 1; i++)
            {
                max1 = max2 = Int32.MaxValue;
                tmp1 = tmp2 = 0;
                //在全部结点中找权值最小的两个结点
                for (int j = 0; j < this.leafNum + i; ++j)
                {
                    if ((data[i].Weight < max1)
                        && (data[i].Parent == -1))
                    {
                        max2 = max1;
                        tmp2 = tmp1;
                        tmp1 = j;
                        max1 = data[j].Weight;
                    }
                    else if ((data[i].Weight < max2)
                             && (data[i].Parent == -1))
                    {
                        max2 = data[j].Weight;
                        tmp2 = j;
                    }
                }

                data[tmp1].Parent = this.leafNum + i;
                data[this.leafNum + i].Weight = data[tmp1].Weight
                                                + data[tmp2].Weight;
                data[this.leafNum + i].LChild = tmp1;
                data[this.leafNum + i].RChild = tmp2;

            }
        }

    }
}
