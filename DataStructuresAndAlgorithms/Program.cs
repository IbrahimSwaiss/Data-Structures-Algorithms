using DataStructuresAndAlgorithms.BInaryTree;
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

                tree.PrintLevelOrderTraversal(); 
            }
        }
    }
}
