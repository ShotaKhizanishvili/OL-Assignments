using Branch_sums;

var root = new BinaryTreeNode(1);

root.Left = new BinaryTreeNode(2);
root.Right = new BinaryTreeNode(3);

root.Left.Left = new BinaryTreeNode(4);
root.Left.Right = new BinaryTreeNode(5);
root.Right.Left = new BinaryTreeNode(6);
root.Right.Right = new BinaryTreeNode(7);

root.Left.Left.Left = new BinaryTreeNode(8);
root.Left.Left.Right = new BinaryTreeNode(9);

root.Left.Right.Left = new BinaryTreeNode(10);

var sums = BranchSums(root);
Console.WriteLine(string.Join(", ", sums)); // უნდა გამოიტანოს 15, 16, 18, 10, 11


static List<int> BranchSums(BinaryTreeNode root)
{
    var sum = new List<int>();
    GetBranchSum(root, 0, sum);
    return sum;
}
static void GetBranchSum(BinaryTreeNode tree, int runningSum, List<int> sum)
{
    if (tree == null) return;

    int totalSum = runningSum + tree.Value;
    if (tree.Left == null && tree.Right == null)
    {
        sum.Add(totalSum);
        return;
    }
    GetBranchSum(tree.Left, totalSum, sum);
    GetBranchSum(tree.Right, totalSum, sum);
}
