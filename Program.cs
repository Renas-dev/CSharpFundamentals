using Helpers;
// SleepTimeCalculations.RunMenu();
// sorted array required for binary search
int[] numbers = {1,2,3,4,6,7,8,13,123};
//our target number to find in the tree
int target = 11111;
//initializing the binarySearch.cs method to find the target in numbers
int index = BinarySearch.Find(numbers, target);
if (index == -1)
{
    Console.WriteLine("Number not in index");
    }
else
{
        Console.WriteLine($"Number fount at index {index}");
}

