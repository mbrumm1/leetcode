using System;

namespace leetcode;
public sealed class Solution_0171_ExcelSheetColumnNumber
{
    public int TitleToNumber(string columnTitle)
    {
        double sum = 0;

        for (int i = 0; i < columnTitle.Length; i++)
        {
            sum += (columnTitle[i] - 64) * Math.Pow(26, columnTitle.Length - 1 - i);
        }

        return (int)sum;
    }
}
