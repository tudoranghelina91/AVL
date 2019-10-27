using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary.Search.Tree
{
    public class BinarySearchTreeNode
    {
        public int Value { get; private set; }
        internal int BalanceFactor { get; private set; }
        internal BinarySearchTreeNode _left;
        internal BinarySearchTreeNode _right;
        public BinarySearchTreeNode Left { get => _left; private set => _left = value; }
        public BinarySearchTreeNode Right { get => _right; private set => _right = value; }
        public BinarySearchTreeNode(int value)
        {
            Value = value;
        }
        private int getDepth(BinarySearchTreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            else
            {
                return 1 + Math.Max(getDepth(root.Left), getDepth(root.Right));
            }
        }
        internal void SetBalanceFactor()
        {
            if (this == null)
                return;

            else
                BalanceFactor = getDepth(Left) - getDepth(Right);
        }
        internal bool IsBalanced()
        {
            if (Math.Abs(BalanceFactor) > 1)
                return false;

            return true;
        }
    }
}
