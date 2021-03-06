﻿using System;

namespace Relearn_Diagram
{
    public class DirectNetAdjMatrix<T> : IGraph<T>
    {
        private Node<T>[] nodes;  //有向网的顶点数组
        private int numArcs;      //弧的数目
        private int[,] matrix;    //临接矩阵数组

        #region 属性

        //弧数目属性
        public int NumArcs
        {
            get
            {
                return numArcs;
            }
            set
            {
                numArcs = value;
            }
        }

        #endregion 属性

        #region 构造

        //构造
        public DirectNetAdjMatrix(int n)
        {
            nodes = new Node<T>[n];
            matrix = new int[n, n];
            numArcs = 0;
        }

        #endregion 构造

        #region 方法

        //获取索引为index的顶点的信息
        public Node<T> GetNode(int index)
        {
            return nodes[index];
        }

        //设置索引为index的顶点的信息
        public void SetNode(int index, Node<T> v)
        {
            nodes[index] = v;
        }

        //获取matrix[index1, index2]的值
        public int GetMatrix(int index1, int index2)
        {
            return matrix[index1, index2];
        }

        //设置matrix[index1, index2]的值
        public void SetMatrix(int index1, int index2, int v)
        {
            matrix[index1, index2] = v;
        }

        //获取顶点数目
        public int GetNumOfVertex()
        {
            return nodes.Length;
        }

        //获取弧的数目
        public int GetNumOfEdge()
        {
            return numArcs;
        }

        //判断v是否是网的顶点
        public bool IsNode(Node<T> v)
        {
            //遍历顶点数组
            foreach (Node<T> nd in nodes)
            {
                //如果顶点nd与v相等，则v是图的顶点，返回true
                if (v.Equals(nd))
                {
                    return true;
                }
            }
            return false;
        }

        //获取v在顶点数组中的索引
        public int GetIndex(Node<T> p)
        {
            for (int i = 0; i < nodes.Length; i++)
            {
                if (nodes[i].Equals(p))
                {
                    return i;
                }
            }
            return -1;
        }

        //在v1和v2之间添加权为v的弧
        public void SetEdge(Node<T> v1, Node<T> v2, int v)
        {
            //v1或v2不是网的顶点
            if (!IsNode(v1) || !IsNode(v2))
            {
                Console.WriteLine("Node is not belong to Graph!");
                return;
            }
            matrix[GetIndex(v1), GetIndex(v2)] = v;
            ++numArcs;
        }

        //删除v1和v2之间的弧
        public void DelEdge(Node<T> v1, Node<T> v2)
        {
            //v1或v2不是网的顶点
            if (!IsNode(v1) || !IsNode(v2))
            {
                Console.WriteLine("Node is not belong to Graph!");
                return;
            }
            //v1和v2之间存在弧
            if (matrix[GetIndex(v1), GetIndex(v2)] != int.MaxValue)
            {
                matrix[GetIndex(v1), GetIndex(v2)] = int.MaxValue;
                --numArcs;
            }
        }

        //判断v1和v2之间是否存在弧
        public bool IsEdge(Node<T> v1, Node<T> v2)
        {
            //v1或v2不是网的顶点
            if (!IsNode(v1) || !IsNode(v2))
            {
                Console.WriteLine("Node is not belong to Graph!");
                return false;
            }

            //v1和v2之间存在弧
            if (matrix[GetIndex(v1), GetIndex(v2)] != int.MaxValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 狄克斯特拉算法的实现(求有向网中的最短路径)
        /// </summary>
        /// <param name="pathMatrixArr">保存从源点到某个顶点的最短路径上的顶点</param>
        /// <param name="shorPathArr">保存从源点到各个顶点的最短路径的长度</param>
        /// <param name="n">源点</param>
        public void Dijkstra(ref bool[,] pathMatrixArr, ref int[] shortPathArr, Node<T> n)
        {
            int k = 0;
            bool[] final = new bool[nodes.Length]; //表示某顶点的最短路径是否已经找到

            //初始化
            for (int i = 0; i < nodes.Length; i++)
            {
                final[i] = false;
                shortPathArr[i] = matrix[GetIndex(n), i];

                for (int j = 0; j < nodes.Length; j++)
                {
                    pathMatrixArr[i, j] = false;
                }
                if (shortPathArr[i] != 0 && shortPathArr[i] < int.MaxValue)
                {
                    pathMatrixArr[i, GetIndex(n)] = true;
                    pathMatrixArr[i, i] = true;
                }
            }

            // n为源点
            shortPathArr[GetIndex(n)] = 0;
            final[GetIndex(n)] = true;

            //处理从源点到其余顶点的最短路径
            for (int i = 0; i < nodes.Length; i++)
            {
                int min = int.MaxValue;

                //比较从源点到其余顶点的路径长度
                for (int j = 0; j < nodes.Length; ++j)
                {
                    //从源点到j顶点的最短路径还没有找到
                    if (!final[j])
                    {
                        // 从源点到j顶点的路径长度最小
                        if (shortPathArr[j] < min)
                        {
                            k = j;
                            min = shortPathArr[j];
                        }
                    }
                }

                //源点到顶点k的路径长度最小
                final[k] = true;

                //更新当前最短路径及距离
                for (int j = 0; j < nodes.Length; ++j)
                {
                    if (!final[j] && (min + matrix[k, j] < shortPathArr[j]))
                    {
                        shortPathArr[j] = min + matrix[k, j];
                        for (int w = 0; w < nodes.Length; ++w)
                        {
                            pathMatrixArr[j, w] = pathMatrixArr[k, w];
                        }
                        pathMatrixArr[j, j] = true;
                    }
                }
            }
        }

        #endregion 方法
    }
}