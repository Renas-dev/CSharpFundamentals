namespace Helpers
{
    // Static helper class that contains the binary search algorithm
    // This class does not hold state and only provides logic
    public static class BinarySearch
    {
        // Searches for a target value inside a sorted integer array
        // Returns the index of the target if found, otherwise returns -1
        public static int Find(int[] numbers, int target)
        {
            // Left boundary of the search range (start of the array)
            int low = 0;

            // Right boundary of the search range (end of the array)
            int high = numbers.Length - 1;

            // Continue searching while there is still a valid range
            while (low <= high)
            {
                // Calculate the middle index of the current search range
                // This formula avoids integer overflow
                int mid = low + (high - low) / 2;

                // Get the value at the middle index for comparison
                int midValue = numbers[mid];

                // If the middle value is the target, return its index
                if (midValue == target)
                {
                    return mid;
                }

                // If the middle value is smaller than the target,
                // discard the left half and search the right half
                if (midValue < target)
                {
                    low = mid + 1;
                }
                else
                {
                    // If the middle value is larger than the target,
                    // discard the right half and search the left half
                    high = mid - 1;
                }
            }

            // If the loop ends, the target does not exist in the array
            return -1;
        }
    }
}
