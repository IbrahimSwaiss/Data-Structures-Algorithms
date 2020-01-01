using DataStructuresAndAlgorithms.BInaryTree;
using System;
using static System.Console;

namespace DataStructuresAndAlgorithms {
    internal class Program {
        private static void Main(string[] args) {
            CreateBinaryTree();
        }

        private static void CreateBinaryTree() {
            while (true) {
                WriteLine("Please enter tree size:");
                int noOfItems = int.Parse(ReadLine());
                Clear();
                if (noOfItems < 0) break;

                BinaryTree tree = null;
                for (int i = 1; i <= noOfItems; i++) {
                    if (tree == null)
                        tree = new BinaryTree(i);
                    else
                        tree.Insert(i);
                }


                ForegroundColor = ConsoleColor.Green;
                WriteLine("Print pre order: root - left - right");
                tree.PrintPreOrder();
                WriteLine();

                ForegroundColor = ConsoleColor.Red;
                WriteLine("Print in order: left - root - right");
                tree.PrintInOrder();
                WriteLine();

                ForegroundColor = ConsoleColor.Cyan;
                WriteLine("Print post order: left - right - root");
                tree.PrintPostOrder();
                WriteLine();

                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Print level order");
                tree.PrintLevelOrderTraversal();
                WriteLine();
                ResetColor();
            }
        }
    }
}
