// Generated by Fuzzlyn v1.1 on 2018-08-12 11:55:50
// Seed: 477095806717887704
// Reduced from 3.4 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ulong s_1;
    static long[, ] s_2 = new long[, ]{{0}};
    public static void Main()
    {
        s_1 = (ulong)((0 & s_2[0, 0]) % (1 | s_2[0, 0]));
    }
}
