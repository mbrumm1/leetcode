namespace leetcode;
public sealed class Solution_0551_StudentAttendanceRecordI
{
    public bool CheckRecord(string s)
    {
        int absentDays = 0;
        int consecutiveLateDays = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == 'A')
            {
                absentDays++;
            }
            
            if (s[i] == 'L')
            {
                consecutiveLateDays++; 
            }

            if (s[i] != 'L')
            {
                consecutiveLateDays = 0;
            }

            if (absentDays >= 2)
            {
                return false;
            }

            if (consecutiveLateDays >= 3)
            {
                return false;
            }
        }
        return true;
    }
}
