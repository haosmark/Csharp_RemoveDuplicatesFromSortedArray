/* 
 * Problem description: Given a sorted array, remove the duplicates in place such 
 * that each element appear only once and return the new length.
 * 
 * Do not allocate extra space for another array, you must do this in place with constant memory.
 * 
 * For example: Given input array nums = [1,1,2]
 * Your function should return length = 2, with the first two elements of nums being 1 and 2 
 * respectively. It doesn't matter what you leave beyond the new length.
*/

namespace RemoveDuplicatesFromSortedArray
{
    public class Solution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            // solve by going through the array and an index to track last unique, and 
            // the associated value

            // corner-case: empty array
            if (nums.Length == 0)
            {
                return 0;
            }

            int luIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                // if nums[i] and last unique value don't match then update last unique value and index
                if (nums[i] != nums[luIndex])
                {
                    luIndex++;
                    nums[luIndex] = nums[i];
                }
            }

            return luIndex + 1;
        }
    }
}
