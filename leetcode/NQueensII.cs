using BenchmarkDotNet.Filters;
using Microsoft.Diagnostics.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode;
public sealed class NQueensII
{
    private char[,] board;
    private int n;

    public int TotalNQueens(int n)
    {
        board = new char[n, n];
        this.n = n;
        return TotalNQueens();
    }

    public int TotalNQueens(int row = 0, int count = 0)
    {
        for (int col = 0; col < n; ++col)
        {
            if (IsNotUnderAttack(row, col))
            {
                PlaceQueen(row, col);

                if (row + 1 == n)
                {
                    ++count;
                }
                else
                {
                    count = TotalNQueens(row + 1, count);
                }

                RemoveQueen(row, col);
            }
        }

        return count;
    }

    private bool IsNotUnderAttack(int row, int col) => !(board[row, col] == 'x');

    private void PlaceQueen(int row, int col)
    {
        board[row, col] = 'q';

        for (int i = 0; i < n; ++i)
        {
            if (i != col && i != row)
            {
                board[row, i] = 'x';
                board[i, col] = 'x';
            }

            // TODO: Mark diagnol squares as being under attack.
        }
    }

    private void RemoveQueen(int row, int col)
    {

    }
}
