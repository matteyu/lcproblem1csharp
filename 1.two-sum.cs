/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var m = new Hashtable();

        for(var i = 0; i<nums.Length; i++){
            if(m.ContainsKey(nums[i])){
                return new int[] {(int)m[nums[i]],i};
            }
            m[target - nums[i]] = i;
        }
        return null;
    }
}
// @lc code=end

