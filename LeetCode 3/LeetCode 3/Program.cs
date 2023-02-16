// See https://aka.ms/new-console-template for more information
LeetCode_3 cls = new();

Console.WriteLine(cls.LengthOfLongestSubstring("abcabcbb"));
Console.WriteLine(cls.LengthOfLongestSubstring("bbbbb"));
Console.WriteLine(cls.LengthOfLongestSubstring("pwwkew"));



public class LeetCode_3
{
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        var map = new Dictionary<int, int>();
        var maxLen = 0;
        var lastRepeatPos = -1;
        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]) && lastRepeatPos < map[s[i]])
                lastRepeatPos = map[s[i]];
            if (maxLen < i - lastRepeatPos)
                maxLen = i - lastRepeatPos;
            map[s[i]] = i;
        }

        return maxLen;
    }
}

