public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> NUMS = new HashSet<int>();
        foreach(int j in nums){
            NUMS.Add(j);
        }
        if(NUMS.Count == nums.Length){
            return(false);
        }
        else
        {
            return(true);
        }

    }
}