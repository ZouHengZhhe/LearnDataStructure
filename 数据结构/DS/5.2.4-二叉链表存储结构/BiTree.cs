using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3._2_队列;

namespace _5._2._4_二叉链表存储结构
{
    /// <summary>
    /// 不带头结点的二叉树的二叉链表的类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BiTree<T>
    {
        private Node<T> head;

        //头引用属性
        public Node<T> Head
        {
            get { return head; }
            set { head = value; }
        }

        //构造
        public BiTree()
        {
            head = null;
        }

        public BiTree(T val)
        {
            Node<T> p = new Node<T>(val);
            head = p;
        }

        public BiTree(T val, Node<T> lp, Node<T> rp)
        {
            Node<T> p = new Node<T>(val, lp, rp);
            head = p;
        }

        //判断是否是空二叉树
        public bool isEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //获取根节点
        public Node<T> Root()
        {
            return head;
        }

        //获取节点的左孩子节点
        public Node<T> GetLChild(Node<T> p)
        {
            return p.LChild;
        }

        //获取节点的右孩子节点
        public Node<T> GetRChild(Node<T> p)
        {
            return p.RChild;
        }

        //将节点p的左子树插入值为val的新节点，
        //原来的左子树成为新节点的左子树
        public void InsertL(T val, Node<T> p)
        {
            Node<T> tmp = new Node<T>(val);
            tmp.LChild = p.LChild;
            p.LChild = tmp;
        }

        //将节点p的右子树插入值为val的新节点，
        //原来的右子树成为新节点的右子树
        public void InsertR(T val, Node<T> p)
        {
            Node<T> tmp = new Node<T>(val);
            tmp.RChild = p.RChild;
            p.RChild = tmp;
        }

        //若p非空，删除p的左子树
        public Node<T> DeleteL(Node<T> p)
        {
            if ((p == null) || (p.LChild == null))
            {
                return null;
            }
            Node<T> tmp = p.LChild;
            p.LChild = null;
            return tmp;
        }

        //若p非空，删除p的右子树
        public Node<T> DeleteR(Node<T> p)
        {
            if ((p == null) || (p.RChild == null))
            {
                return null;
            }
            Node<T> tmp = p.RChild;
            p.RChild = null;
            return tmp;
        }

        //判断是否是叶子节点
        public bool IsLeaf(Node<T> p)
        {
            if ((p != null) && (p.LChild == null) && (p.RChild == null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //二叉树中查找值为 value 的结点。
        public Node<T> Search(Node<T> root, T value)
        {
            Node<T> p = root;
            if (p == null)
            {
                return null;
            }

            if (!p.Data.Equals(value))
            {
                return p;
            }
            if (p.LChild != null)
            {
                return Search(p.LChild, value);
            }
            if (p.RChild != null)
            {
                return Search(p.RChild, value);
            }
            return null;
        }

        //统计出二叉树中叶子结点的数目。
        public int CountLeafNode(Node<T> root)
        {
            if (root == null)
            {
                return 0;
            }
            else if (root.LChild == null && root.RChild == null)
            {
                return 1;
            }
            else
            {
                return (CountLeafNode(root.LChild) +CountLeafNode(root.RChild));
            }
        }

        //求二叉树的深度
        public int GetHeight(Node<T> root)
        {
            int lh;
            int rh;
            if (root == null)
            {
                return 0;
            }
            else if (root.LChild == null && root.RChild == null)
            {
                return 1;
            }
            else
            {
                lh = GetHeight(root.LChild);
                rh = GetHeight(root.RChild);
                return (lh > rh ? lh : rh) + 1;
            }
        }

        /// <summary>
        /// 先序遍历
        /// </summary>
        /// <param name="root"></param>
        public void PreOrder(Node<T> root)
        {
            //根节点为空
            if (root == null)
            {
                return;
            }
            //处理根节点
            Console.WriteLine("{0}", root.Data);

            //遍历左子树
            PreOrder(root.LChild);

            //遍历右子树
            PreOrder(root.RChild);
        }

        /// <summary>
        /// 中序遍历
        /// </summary>
        /// <param name="root"></param>
        public void InOrder(Node<T> root)
        {
            //根结点为空
            if (root == null)
            {
                return;
            }
            //中序遍历左子树
            InOrder(root.LChild);
            //处理根结点
            Console.WriteLine("{0}", root.Data);
            //中序遍历右子树
            InOrder(root.RChild);
        }

        /// <summary>
        /// 后序遍历
        /// </summary>
        /// <param name="root"></param>
        public void PostOrder(Node<T> root)
        {
            //根结点为空
            if (root == null)
            {
                return;
            }
            //后序遍历左子树
            PostOrder(root.LChild);
            //后序遍历右子树
            PostOrder(root.RChild);
            //处理根结点
            Console.WriteLine("{0}", root.Data);
        }

        /// <summary>
        /// 层序遍历
        /// </summary>
        /// <param name="root"></param>
        public void LevelOrder(Node<T> root)
        {
            if (root == null)
            {
                return;
            }

            //设置一个队列保存层序遍历的结点
            CSeqQueue<Node<T>> sq = new CSeqQueue<Node<T>>(50);

            //根结点入队
            sq.In(root);
            //队列非空，结点没有处理完
            while (!sq.IsEmpty())
            {
                //结点出队
                Node<T> tmp = sq.Out();
                //处理当前结点
                Console.WriteLine("{0}", tmp);
                //将当前结点的左孩子结点入队
                if (tmp.LChild != null)
                {
                    sq.In(tmp.LChild);
                }
                //将当前结点的右孩子结点入队
                if (tmp.RChild != null)
                {
                    sq.In(tmp.RChild);
                }
            }

        }

    }
}
