using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_Tree
{
    //不带头结点的二叉树的二叉链表的类
    public class BiTree<T>
    {
        private Node<T> head;

        public Node<T> Head
        {
            get { return head; }
            set { head = value; }
        }

        #region 构造

        public BiTree()
        {
            head = null;
        }

        public BiTree(T val)
        {
            Node<T> p=new Node<T>(val);
            head = p;
        }

        public BiTree(T val, Node<T> l, Node<T> r)
        {
            Node<T> p=new Node<T>(val,l,r);
            head = p;
        }

        #endregion

        #region 方法

        //判断是否是空二叉树
        public bool IsEmpty()
        {
            if (head==null)
            {
                return true;
            }
            return false;
        }

        //获取根节点
        public Node<T> Root()
        {
            return head;
        }

        //获取结点的左孩子节点
        public Node<T> GetLChild(Node<T> p)
        {
            return p.LChild;
        }

        //获取节点的右孩子节点
        public Node<T> GetRChild(Node<T> p)
        {
            return p.RChild;
        }

        //将节点p的左子树插入值为val的新节点上，原来的左子树成为新节点的左子树
        public void InsertL(T val, Node<T> p)
        {
            Node<T> q=new Node<T>(val);
            q.LChild = p.LChild;
            p.LChild = q;
        }

        //将结点p的右子树插入值为val的新结点，原来的右子树成为新结点的右子树
        public void InsertR(T val, Node<T> p)
        {
            Node<T> q=new Node<T>(val);
            q.RChild = p.RChild;
            p.RChild = q;

        }

        //若p非空，删除p的左子树
        public void DeleteL(Node<T> p)
        {
            if (p==null||p.LChild==null)
            {
                return ;
            }
            p.LChild = null;
        }

        //若p非空，删除p的右子树
        public void DeleteR(Node<T> p)
        {
            if (p==null||p.RChild==null)
            {
                return;
            }
            p.RChild = null;
        }

        //判断是否是叶子结点
        public bool IsLeaf(Node<T> p)
        {
            if (p==null&&p.RChild==null&&p.LChild==null)
            {
                return true;
            }
            return false;
        }

        #endregion

    }
}
