public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frecuencia = new Dictionary<int, int>();
        foreach(int num in nums){
            if(!frecuencia.ContainsKey(num)) {
                frecuencia[num] = 0;
            }
        frecuencia[num]++;
        }
        return frecuencia
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
    }
}
