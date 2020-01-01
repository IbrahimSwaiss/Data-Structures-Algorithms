using DataStructuresAndAlgorithms.BT;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace DataStructuresAndAlgorithms.BInaryTree {
    public static class BinaryTreeUtilities {
        public static void Insert(this BinaryTree tree, int value) {
            if (tree == null)
                return;

            if (tree.Root == null)
                tree.Root = new Node { Value = value };

            var queue = new Queue<Node>();
            queue.Enqueue(tree.Root);

            while (queue.Any()) {
                var node = queue.Dequeue();

                if (node.Left == null) {
                    node.Left = new Node { Value = value };
                    return;
                }

                if (node.Right == null) {
                    node.Right = new Node { Value = value };
                    return;
                }

                queue.Enqueue(node.Left);
                queue.Enqueue(node.Right);
            }
        }


        //public static void Delete(this BinaryTree tree, int value) {
        //    var queue = new Queue<BinaryTree>();
        //    queue.Enqueue(tree);

        //    while (queue.Any()) {
        //        var node = queue.Dequeue();
        //        if (node.Value == value) {
        //            node.Value = GetAndDeleteDeepestNodeValueToTheLeft(tree);
        //            //DeleteDeepestValue(tree);
        //            return;
        //        }

        //        if (node.Left != null)
        //            queue.Enqueue(node.Left);

        //        if (node.Right != null)
        //            queue.Enqueue(node.Right);
        //    }
        //}

        //private static int GetAndDeleteDeepestNodeValueToTheLeft(BinaryTree tree) {
        //    BinaryTree parent, current = null;
        //    parent = current;
        //    current = tree;

        //    if (tree == null)
        //        return 0;

        //    if (current.Left == null && current.Right == null) {
        //        parent.Left = null;
        //        return current.Value;
        //    }

        //    return GetAndDeleteDeepestNodeValueToTheLeft(parent.Left);
        //}

        //private static void DeleteDeepestValueT(BinaryTree tree) {
        //    var queue = new Queue<BinaryTree>();
        //    BinaryTree previousNode, currentNode = null;

        //    queue.Enqueue(tree);

        //    while (queue.Any()) {
        //        previousNode = currentNode;
        //        currentNode = queue.Dequeue();

        //        if (currentNode.Left == null && currentNode.Right == null) {
        //            currentNode = null;
        //            previousNode.Left = null;
        //            previousNode.Right = null;
        //            return;
        //        }

        //        if (currentNode.Left != null)
        //            queue.Enqueue(currentNode.Left);

        //        if (currentNode.Right != null)
        //            queue.Enqueue(currentNode.Right);
        //    }
        //}

        //private static int GetDeepestNodeValue(BinaryTree tree) {
        //    var queue = new Queue<BinaryTree>();
        //    queue.Enqueue(tree);

        //    while (queue.Any()) {
        //        var node = queue.Dequeue();

        //        if (node.Left == null && node.Right == null)
        //            return node.Value;

        //        if (node.Left != null)
        //            queue.Enqueue(node.Left);

        //        if (node.Right != null)
        //            queue.Enqueue(node.Right);
        //    }
        //    return 0;
        //}

        /// <summary>
        /// Print root - left - right
        /// </summary>
        public static void PrintPreOrder(this Node node) {
            if (node == null) return;
            Write($"{node.Value} ");
            PrintPreOrder(node.Left);
            PrintPreOrder(node.Right);
        }

        /// <summary>
        /// Print left - root - right
        /// </summary>
        public static void PrintInOrder(this Node node) {
            if (node == null) return;
            PrintInOrder(node.Left);
            Write($"{node.Value} ");
            PrintInOrder(node.Right);
        }

        /// <summary>
        /// Print left - right - root
        /// </summary>
        public static void PrintPostOrder(this Node node) {
            if (node == null) return;
            PrintPostOrder(node.Left);
            PrintPostOrder(node.Right);
            Write($"{node.Value} ");
        }

        /// <summary>
        /// Print by level
        /// </summary>
        /// <param name="root"></param>
        public static void PrintLevelOrderTraversal(this Node root) {
            if (root == null) {
                WriteLine("Empty tree");
            } else {
                var queue = new Queue<Node>();
                queue.Enqueue(root);
                while (queue.Any()) {
                    var node = queue.Peek();

                    if (node.Left != null)
                        queue.Enqueue(node.Left);
                    if (node.Right != null)
                        queue.Enqueue(node.Right);

                    Write($"{node.Value} ");
                    queue.Dequeue();
                }
            }
        }
    }
}
