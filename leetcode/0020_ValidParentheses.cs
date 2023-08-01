using System.Collections.Generic;

public class Solution_0020_ValidParentheses
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
            return false;

        var map = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

        var stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (stack.Count == 0)
                stack.Push(s[i]);
            else if (map.ContainsKey(stack.Peek()) && map[stack.Peek()] == s[i])
                stack.Pop();
            else
                stack.Push(s[i]);
        }
        return stack.Count == 0;
    }
}

