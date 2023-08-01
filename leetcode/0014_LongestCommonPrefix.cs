using System.Linq;

public class Solution_0014_LongestCommonPrefix
{
    public string LongestCommonPrefix(params string[] strs)
    {
        var sorted = strs.OrderBy(s => s);
        return string.Concat(sorted
            .First()
            .Zip(sorted.Last())
            .TakeWhile(s => s.First == s.Second)
            .Select(x => x.First));
    }
}

