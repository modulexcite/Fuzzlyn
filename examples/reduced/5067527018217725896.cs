// Generated by Fuzzlyn on 2018-07-26 03:52:08
// Seed: 5067527018217725896
// Reduced from 14.9 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static char[, ] s_1 = new char[, ]{{'J'}};
    static int s_8;
    public static void Main()
    {
        bool vr3 = ((s_1[0, 0] & 0) | s_1[0, 0]) > 0;
        if (vr3)
        {
            var vr4 = s_8;
        }
        else
        {
        }
    }
}