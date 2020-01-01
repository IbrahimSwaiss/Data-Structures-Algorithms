namespace DataStructuresAndAlgorithms.BInaryTree {
    public class BinaryTree {
        public int Value { get; }
        public BinaryTree Left { get; set; }
        public BinaryTree Right { get; set; }

        public BinaryTree (int value) {
            Value = value;
        }
    }
}
