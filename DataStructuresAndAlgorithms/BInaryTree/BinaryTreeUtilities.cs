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

        public static void PrintPreOrder(this BinaryTree tree) {
            
        }
        public static void PrintInOrder(this BinaryTree tree) {
            
        }
        public static void PrintPostOrder(this BinaryTree tree) {
            
        }
        public static void PrintLevelOrderTraversal(this BinaryTree tree) {
            ForegroundColor = System.ConsoleColor.Yellow;
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

                    WriteLine(node.Value);
                    queue.Dequeue();
                }
            }
            ResetColor();
        }
    }
}
