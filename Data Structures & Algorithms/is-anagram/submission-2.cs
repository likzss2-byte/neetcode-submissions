public class Solution {
    public bool IsAnagram(string s, string t) {
        string s2 = new string(s.OrderBy(letra => letra).ToArray());
        string t2 = new string(t.OrderBy(letra => letra).ToArray());
        if (s2 == t2){
            return(true);
        }
        else{
            return(false);
        }
    
    }
}
