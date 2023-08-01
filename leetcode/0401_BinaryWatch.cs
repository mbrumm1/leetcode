using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace leetcode;
public sealed class Solution_0401_BinaryWatch
{
    public IList<string> ReadBinaryWatch(int turnedOn)
    {
        var times = new List<string>();
        if (turnedOn >= 9)
        {
            return times;
        }

        if (turnedOn == 0)
        {
            times.Add("0:00");
            return times;
        }

        for (int hour = 0; hour < 12; ++hour)
        {
            for (int minute = 0; minute < 60; ++minute)
            {
                if (CountOnBits(hour) + CountOnBits(minute) == turnedOn && hour <= 11 && minute <= 59)
                {
                    string time = $"{hour}:{minute.ToString().PadLeft(2, '0')}";
                    times.Add(time);
                }
            }
        }

        return times;
    }

    private int CountOnBits(int n)
    {
        int onBits = 0;
        while (n > 0)
        {
            if ((n & 1) == 1)
            {
                ++onBits;
            }
            n >>= 1;
        }
        return onBits;
    }
}
