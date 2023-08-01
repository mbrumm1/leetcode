using System.Collections.Generic;
using System.Linq;

namespace leetcode;
public sealed class Solution_0412_FizzBuzz
{
    public IList<string> FizzBuzz(int n) => Enumerable.Range(1, n)
        .Select(x => (x % 3 == 0, x % 5 == 0) switch
            {
                (true, true) => "FizzBuzz",
                (true, false) => "Fizz",
                (false, true) => "Buzz",
                (false, false) => x.ToString()
            })
        .ToList();
}
