public class Solution {
  public int Search(int[] nums, int target) {
    int arrayAverageIndex = nums.Length / 2;
    int arrayAverageValue = nums[arrayAverageIndex];

    if (arrayAverageValue == target)
      return arrayAverageIndex;

    int startIndex = arrayAverageValue < target ? arrayAverageIndex : 0;
    int endIndex = arrayAverageValue < target ? nums.Length: arrayAverageIndex;

    for (int i = startIndex ;  i < endIndex ; i++ ) {
      if (nums[i] == target) {
        return i;
      }
    }
    return -1;
  }
}