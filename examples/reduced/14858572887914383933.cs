// Generated by Fuzzlyn on 2018-07-04 00:34:25
// Seed: 14858572887914383933
// Reduced from 6.7 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public ulong F2;
}

public class Program
{
    static C0[, ] s_1 = new C0[, ]{{new C0()}};
    public static void Main()
    {
        int vr3 = (int)((s_1[0, 0].F2 & 0) % (s_1[0, 0].F2 | 1));
    }
}
