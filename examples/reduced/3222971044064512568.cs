// Generated by Fuzzlyn on 2018-07-16 04:22:54
// Seed: 3222971044064512568
// Reduced from 20.6 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static int[, ] s_1 = new int[, ]{{0}};
    public static void Main()
    {
        bool vr4 = (ulong)(0 & s_1[0, 0]) >= (ulong)s_1[0, 0];
        if (vr4)
        {
            s_1 = s_1;
        }
    }
}