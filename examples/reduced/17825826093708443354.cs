// Generated by Fuzzlyn on 2018-07-10 21:32:37
// Seed: 17825826093708443354
// Reduced from 309.9 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public int F0;
    public short F2;
}

public class Program
{
    static C0[, ] s_7 = new C0[, ]{{new C0()}};
    static C0 s_31 = new C0();
    public static void Main()
    {
        var vr37 = (sbyte)(0 & s_7[0, 0].F2);
        M18(vr37);
        int vr38 = s_31.F0;
    }

    static long[] M18(sbyte arg0)
    {
        return new long[]{0, -3650002868611908822L, 0};
    }
}