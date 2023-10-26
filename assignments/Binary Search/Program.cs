namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 0, 1, 5, 76, 234, 678 };
            var target = 76;

            var index = BinarySearch(array, target);
            Console.WriteLine(index); // index უნდა იყოს 3

            index = BinarySearch(array, 75);
            Console.WriteLine(index); // index უნდა იყოს -1
        }
        public static int BinarySearch(int[] arr, int target)
        {
            int min = 0;
            int max = arr.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return -1;
        }     
    }
}