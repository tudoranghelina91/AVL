using System;

namespace AVLTree
{
    public class AvlTreeNode
    {
        public int Value { get; private set; }
        internal int BalanceFactor { get; private set; }
        internal AvlTreeNode _left;
        internal AvlTreeNode _right;
        public AvlTreeNode Left { get => _left; private set => _left = value; }
        public AvlTreeNode Right { get => _right; private set => _right = value; }
        public AvlTreeNode(int value)
        {
            Value = value;
        }
        private int getDepth(AvlTreeNode root)
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
