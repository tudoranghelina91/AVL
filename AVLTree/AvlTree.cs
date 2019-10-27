using System;

namespace AVLTree
{
    public class AvlTree
    {
        private AvlTreeNode _root;
        private AvlTreeNode search(int value, AvlTreeNode root)
        {
            if (root == null)
                return null;

            if (value < root.Value)
            {
                search(value, root.Left);
            }

            if (value > root.Value)
            {
                search(value, root.Right);
            }

            return root;
        }
        private AvlTreeNode removeGreatestNode(ref AvlTreeNode root)
        {
            AvlTreeNode current;
            if (root.Right == null)
            {
                current = root;
                root = root.Right;
                return current;
            }

            else
            {
                return removeGreatestNode(ref root._right);
            }
        }
        private void deleteRoot(ref AvlTreeNode root)
        {
            AvlTreeNode current = root;
            if (root.Left == null)
            {
                root = root.Right;
            }

            else if (root.Right == null)
            {
                root = root.Left;
            }

            else
            {
                root = removeGreatestNode(ref root._left);
                root._left = current.Left;
                root._right = current.Right;
            }

            recalculateBalanceFactors(ref root);
        }
        private void delete(ref AvlTreeNode root, int value)
        {
            if (root == null)
            {
                return;
            }

            else if (value < root.Value)
            {
                delete(ref root._left, value);
            }

            else if (value > root.Value)
            {
                delete(ref root._right, value);
            }

            else
            {
                deleteRoot(ref root);
                recalculateBalanceFactors(ref root);
            }

            if (root != null && !root.IsBalanced())
            {
                rebalance(ref root);
                if (root.Left != null)
                    rebalance(ref root._left);
                if (root.Right != null)
                rebalance(ref root._right);
            }
            recalculateBalanceFactors(ref root);

        }
        private void rotateRight(ref AvlTreeNode root)
        {
            if (root.Left != null)
            {
                AvlTreeNode tmp = root.Left;
                root._left = tmp.Right;
                tmp._right = root;
                root = tmp;
                recalculateBalanceFactors(ref root);
            }
        }
        private void rotateLeft(ref AvlTreeNode root)
        {
            if (root.Right != null)
            {
                AvlTreeNode tmp = root.Right;
                root._right = tmp.Left;
                tmp._left = root;
                root = tmp;
                recalculateBalanceFactors(ref root);
            }
        }
        private void rebalance(ref AvlTreeNode root)
        {
            // LL imbalance
            if (root.BalanceFactor > 1 && root.Value < root.Left.Value)
            {
                rotateRight(ref root);
            }
            // RR imbalance
            if (root.BalanceFactor < -1 && root.Value > root.Right.Value)
            {
                rotateLeft(ref root);

            }
            // LR imbalance
            if (root.BalanceFactor > 1 && root.Value > root.Left.Value)
            {
                rotateLeft(ref root._left);
                rotateRight(ref root);
            }
            // RL imbalance
            if (root.BalanceFactor < -1 && root.Value < root.Right.Value)
            {
                rotateRight(ref root._right);
                rotateLeft(ref root);
            }
        }
        private void insert(ref AvlTreeNode root, int value)
        {
            if (root == null)
            {
                root = new AvlTreeNode(value);
            }

            if (value < root.Value)
            {
                insert(ref root._left, value);
            }

            if (value > root.Value)
            {
                insert(ref root._right, value);
            }

            recalculateBalanceFactors(ref root);
            if (!root.IsBalanced())
            {
                rebalance(ref root);
                rebalance(ref root._left);
                rebalance(ref root._right);
            }
            recalculateBalanceFactors(ref root);
        }
        private void recalculateBalanceFactors(ref AvlTreeNode root)
        {
            if (root == null)
                return;

            root.SetBalanceFactor();

            if (root.Left != null)
                root.Left.SetBalanceFactor();
            if (root.Right != null)
                root.Right.SetBalanceFactor();
        }
        private void clear(ref AvlTreeNode root)
        {
            if (root.Left != null)
                clear(ref root._left);

            if (root.Right != null)
                clear(ref root._right);

            root = null;
        }
        private void preOrder(AvlTreeNode root)
        {
            if (root != null)
            {
                Console.Write($"{root.Value} ");
                preOrder(root.Left);
                preOrder(root.Right);
            }
        }
        public AvlTreeNode Root
        { get => _root; set => _root = value; }
        public AvlTree(AvlTreeNode root)
        {
            Root = root;
        }
        public AvlTree()
        {
        }
        public AvlTreeNode Search(int value)
        {
            return search(value, Root);
        }
        public void Delete(int value)
        {
            delete(ref _root, value);
        }
        public void Insert(int value)
        {
            insert(ref _root, value);
        }
        public void Clear()
        {
            clear(ref _root);
        }
        public void PreOrder()
        {
            preOrder(Root);
            Console.WriteLine();
        }
    }
}
