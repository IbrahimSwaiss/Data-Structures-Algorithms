using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace DataStructuresAndAlgorithms.BInaryTree {
    public static class BinaryTreeUtilities {
        public static void Insert(this BinaryTree root, int value) {
            if (root == null) {
                _ = new BinaryTree(value);
                return;
            } else {
                var queue = new Queue<BinaryTree>();
                queue.Enqueue(root);
                while (queue.Any()) {
                    var node = queue.Dequeue();

                    if (node.Left == null) {
                        node.Left = new BinaryTree(value);
                        return;
                    }

                    if (node.Right == null) {
                        node.Right = new BinaryTree(value);
                        return;
                    }

                    queue.Enqueue(node.Left);
                    queue.Enqueue(node.Right);
                }
            }
        }

        /// <summary>
        /// Print root - left - right
        /// </summary>
        public static void PrintPreOrder(this BinaryTree tree) {
            if (tree == null) return;
            Write($"{tree.Value} ");
            PrintPreOrder(tree.Left);
            PrintPreOrder(tree.Right);
        }

        /// <summary>
        /// Print left - root - right
        /// </summary>
        public static void PrintInOrder(this BinaryTree tree) {
            if (tree == null) return;
            PrintInOrder(tree.Left);
            Write($"{tree.Value} ");
            PrintInOrder(tree.Right);
        }

        /// <summary>
        /// Print left - right - root
        /// </summary>
        public static void PrintPostOrder(this BinaryTree tree) {
            if (tree == null) return;
            PrintPostOrder(tree.Left);
            PrintPostOrder(tree.Right);
            Write($"{tree.Value} ");
        }

        public static void PrintLevelOrderTraversal(this BinaryTree tree) {
            if (tree == null) {
                WriteLine("Empty tree");
            } else {
                var queue = new Queue<BinaryTree>();
                queue.Enqueue(tree);
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
