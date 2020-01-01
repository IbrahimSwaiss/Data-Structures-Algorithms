using System;
using static System.Console;
using DataStructuresAndAlgorithms.BT;
using DataStructuresAndAlgorithms.BInaryTree;

namespace DataStructuresAndAlgorithms {
    internal class Program {
        private static void Main(string[] args) {
            CreateBinaryTree();
            //CreateBinaryTreeAndDelete();
        }

        //private static void CreateBinaryTreeAndDelete() {
        //    while (true) {
        //        WriteLine("Please enter tree size:");
        //        int noOfItems = int.Parse(ReadLine());
        //        Clear();
        //        if (noOfItems < 0) break;

        //        BinaryTree tree = new BinaryTree();
        //        for (int i = 1; i <= noOfItems; i++) {
        //                tree.Insert(i);
        //        }

        //        ForegroundColor = ConsoleColor.Yellow;
        //        tree.Node.PrintLevelOrderTraversal();
        //        WriteLine();
        //        ResetColor();

        //        WriteLine("Please enter number to delete:");
        //        int noToDelete = int.Parse(ReadLine());
        //        tree.Delete(noToDelete);

        //        ForegroundColor = ConsoleColor.Yellow;
        //        tree.PrintLevelOrderTraversal();
        //        WriteLine();
        //        ResetColor();
        //    }
        //}

        private static void CreateBinaryTree() {
            while (true) {
                WriteLine("Please enter tree size:");
                int noOfItems = int.Parse(ReadLine());
                Clear();
                if (noOfItems < 0) break;

                BinaryTree tree = new BinaryTree();
                for (int i = 1; i <= noOfItems; i++) {
                    tree.Insert(i);
                }

                ForegroundColor = ConsoleColor.Green;
                WriteLine("Print pre order: root - left - right");
                tree.Root.PrintPreOrder();
                WriteLine();

                ForegroundColor = ConsoleColor.Red;
                WriteLine("Print in order: left - root - right");
                tree.Root.PrintInOrder();
                WriteLine();

                ForegroundColor = ConsoleColor.Cyan;
                WriteLine("Print post order: left - right - root");
                tree.Root.PrintPostOrder();
                WriteLine();

                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Print level order");
                tree.Root.PrintLevelOrderTraversal();
                WriteLine();
                ResetColor();
            }
        }
    }
}
