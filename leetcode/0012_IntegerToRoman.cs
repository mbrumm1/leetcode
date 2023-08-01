using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0012_IntegerToRoman
{
    private static Dictionary<int, char> map = new()
    {
        { 1, 'I' },
        { 5, 'V' },
        { 10, 'X' },
        { 50, 'L' },
        { 100, 'C' },
        { 500, 'D' },
        { 1000, 'M' }
    };

    public string IntToRoman(int num)
    {
        var chars = new List<char>();
        while (num > 0)
        {
            if (num >= 1000)
            {
                chars.Add(map[1000]);
                num -= 1000;
            }
            else if (num >= 900)
            {
                chars.Add(map[100]);
                chars.Add(map[1000]);
                num -= 900;
            }
            else if (num >= 500)
            {
                chars.Add(map[500]);
                num -= 500;
            }
            else if (num >= 400)
            {
                chars.Add(map[100]);
                chars.Add(map[500]);
                num -= 400;
            }
            else if (num >= 100)
            {
                chars.Add(map[100]);
                num -= 100;
            }
            else if (num >= 90)
            {
                chars.Add(map[10]);
                chars.Add(map[100]);
                num -= 90;
            }
            else if (num >= 50)
            {
                chars.Add(map[50]);
                num -= 50;
            }
            else if (num >= 40)
            {
                chars.Add(map[10]);
                chars.Add(map[50]);
                num -= 40;
            }
            else if (num >= 10)
            {
                chars.Add(map[10]);
                num -= 10;
            }
            else if (num == 9)
            {
                chars.Add(map[1]);
                chars.Add(map[10]);
                num -= 9;
            }
            else if (num >= 5)
            {
                chars.Add(map[5]);
                num -= 5;
            }
            else if (num == 4)
            {
                chars.Add(map[1]);
                chars.Add(map[5]);
                num -= 4;
            }
            else if (num >= 1)
            {
                chars.Add(map[1]);
                num -= 1;
            }
        }
        return new string(chars.ToArray());
    }
}
