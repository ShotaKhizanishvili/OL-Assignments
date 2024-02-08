var array = new List<int>() { 2, 1, 2, 2, 2, 3, 4, 2 };
var toMove = 2;

MoveElements(array, toMove);

Console.WriteLine(string.Join(", ", array));

static void MoveElements(List<int> array, int toMove)
{
    int leftPointer = 0;
    int rightPointer = array.Count - 1;

    while (leftPointer < rightPointer)
    {
        if (array[leftPointer] == toMove)
        {          
            int temp = array[leftPointer];
            array[leftPointer] = array[rightPointer];
            array[rightPointer] = temp;
            rightPointer--;
        }
        else
        {
            leftPointer++;
        }
    }
}