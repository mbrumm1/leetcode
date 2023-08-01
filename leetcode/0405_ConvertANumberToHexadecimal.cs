using System.Text;

namespace leetcode;
public sealed class Solution_0405_ConvertANumberToHexadecimal
{
    public string ToHex(int num)
    {
        var digitCharacters = new char[] 
        { 
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',  
            'a', 'b', 'c',  'd', 'e', 'f' 
        };

        var unsigned = (uint)num;
        var sb = new StringBuilder();
        do
        {
            sb.Insert(0, digitCharacters[unsigned & 15]);
            unsigned >>= 4;
        } while (unsigned > 0);

        return sb.ToString();
    }
}
