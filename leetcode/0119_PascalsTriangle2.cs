using System.Collections.Generic;

namespace leetcode;
public sealed class Solution_0119_PascalsTriangle2
{
    public IList<int> GetRow(int rowIndex)
    {
        var rows = new List<List<int>>();

        for (int i = 0; i <= rowIndex; i++)
        {
            rows.Add(new List<int>(i + 1));
            
            for (int j = 0; j < i + 1; j++)
            {
                rows[i].Add(1);
            }

            for (int k = 0; k < rows[i].Count; k++)
            {
                if (k == 0 || k == rows[i].Count - 1)
                {
                    continue;
                }

                rows[i][k] = rows[i - 1][k - 1] + rows[i - 1][k];
            }
        }

        return rows[rowIndex];
    }
}
