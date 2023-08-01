using System;

namespace leetcode;
public sealed class Solution_0434_NumberOfSegmentsInAString
{
    public int CountSegments(string s) => s == "" ? 0 : s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
}
