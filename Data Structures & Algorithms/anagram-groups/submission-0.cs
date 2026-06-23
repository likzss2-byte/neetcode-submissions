public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> grupos = new Dictionary<string, List<string>>();
        foreach (string palabra in strs){
            string key = new string(palabra.OrderBy(x => x).ToArray());
            if(!grupos.ContainsKey(key)){
                grupos[key] = new List<string>();
            }
            grupos[key].Add(palabra);
        }
        return grupos.Values.ToList();
    }
}
