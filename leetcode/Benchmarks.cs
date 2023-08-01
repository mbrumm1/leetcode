using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using System;

namespace leetcode;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    [Params(701, int.MaxValue)]
    public int columnNumber { get; set; }

    private char[] titleX = new char[7];

    [Benchmark]
    public string ConvertToTitle_WithSpan()
    {
        int quotient = 0;
        int remainder = 0;
        int i = titleX.Length - 1;

        while (columnNumber != 0)
        {
            quotient = columnNumber / 26;
            remainder = columnNumber % 26;
            columnNumber = quotient;

            if (remainder == 0)
            {
                columnNumber -= 1;
                remainder = 26;
            }

            titleX[i] = (char)(remainder + 64);
            i--;
        }

        return titleX.AsSpan().Slice(i + 1).ToString();
    }

    [Benchmark]
    public string ConvertToTitle_WithRange()
    {
        int quotient = 0;
        int remainder = 0;
        var title = new char[7];
        int i = title.Length - 1;

        while (columnNumber != 0)
        {
            quotient = columnNumber / 26;
            remainder = columnNumber % 26;
            columnNumber = quotient;

            if (remainder == 0)
            {
                columnNumber -= 1;
                remainder = 26;
            }

            title[i] = (char)(remainder + 64);
            i--;
        }

        return new string(title[(i + 1)..]);
    }

    private int?[] ary = new int?[7];

    [Benchmark]
    public string ConvertToTitle_FastestOnLeetCode()
    {
        var retVal = "";

        for (int i = 0; i < 7; i++)
        {
            ary[i] = 0;
        }

        var remainder = columnNumber;
        for (int i = 6; i >= 0; i--)
        {
            if (columnNumber > Math.Pow(26, i))
            {
                var x = ((int)Math.Pow(26, i));
                remainder = columnNumber / x;
                ary[i] = remainder;
                columnNumber -= (x * remainder);
            }
        }

        if (columnNumber > 0)
        {
            ary[0] += columnNumber;
        }

        StripZeros();

        for (int i = 0; i < 7; i++)
        {
            if (ary[i] == 0 && ary[i + 1] > 0)
            {
                ary[i] = 26;
                ary[i + 1]--;
            }
        }

        StripZeros();

        for (int i = 0; i < 7; i++)
        {
            if (ary[i] != null)
            {
                retVal = Convert.ToChar(ary[i].GetValueOrDefault(26) + 64) + retVal;
            }
        }

        return retVal;
    }

    private void StripZeros()
    {
        for (int i = 6; i >= 0; i--)
        {
            if (ary[i].GetValueOrDefault(0) == 0)
            {
                ary[i] = null;
            }
            else
            {
                break;
            }
        }
    }
}
