// Generated by Fuzzlyn on 2018-07-24 15:58:24
// Seed: 14463919822369136700
// Reduced from 40.5 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public short F5;
    public byte F7;
}

public class Program
{
    static C0[, ] s_2 = new C0[, ]{{new C0()}};
    public static void Main()
    {
        var vr2 = s_2[0, 0].F5 & 0;
        var vr3 = s_2[0, 0].F7;
        M1(vr2);
    }

    static ulong M1(long arg0)
    {
        byte[] var0 = new byte[]{1, 0, 0, 10};
        return 0;
    }
}
