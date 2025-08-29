public class Solution {
    public int MinSwaps(string s) {
        var len = s.Length;
        var numOpening = 0;
        var numClosing = 0;
        var numSwaps = 0;
        for (var i = 0; i < len; i++)
        {
            var c = s[i];
            if (c == '[') numOpening++;
            else numClosing++;
            if (numClosing > numOpening)
            {
                numSwaps++;
                numClosing--;
                numOpening++;
            }
        }
        return numSwaps;  
    }
}
