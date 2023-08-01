using Microsoft.Diagnostics.Tracing.Parsers.JScript;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode;
public sealed class Solution_0168_ExcelSheetColumnTitle
{
    public string ConvertToTitle(int columnNumber)
    {
        int quotient = 0;
        int remainder = 0;
        // The max integer value will at max produce 7 characters.
        var title = new char[7];
        // Start from the end of the array and work backwards.
        // Keep dividing the columnNumber until the quotient is 0.
        // Each remainder represents a letter in the alphabet.
        int i = title.Length - 1;

        while (columnNumber != 0)
        {            
            quotient = columnNumber / 26;
            remainder = columnNumber % 26;
            columnNumber = quotient;

            // There isn't zero in Excel columns. A 20 is actually "AZ."
            // So if a remainder is zero, take away 1 from the peceding "digit" which is actually 26 in the next.
            if (remainder == 0)
            {
                columnNumber -= 1;
                remainder = 26;
            }

            // In C# chars are implicitly convertible to int types and vice-versa. The int value represents a unicode value.
            // Since 65 in unicode is "A," then we need to add 64 to each remainder before the conversion. 
            title[i] = (char)(remainder + 64);
            i--;
        }

        // Create as span over the char array. A span is a contiguous block of memory. Slice from the starting point of the actual values so that
        // all \0 (default value of char) are ignored. Benchmarks show that working with a span is slightly faster than using a range to slice the array directly.
        return title.AsSpan().Slice(i + 1).ToString();
    }
}
