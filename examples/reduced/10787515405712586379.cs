// Generated by Fuzzlyn on 2018-07-01 02:18:53
// Seed: 10787515405712586379
// Reduced from 9.5 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public short F6;
    public S0(short f6): this()
    {
        F6 = f6;
    }
}

public class Program
{
    static S0[][][][, ] s_2 = new S0[][][][, ]{new S0[][][, ]{new S0[][, ]{new S0[, ]{{new S0(-1442)}}}}};
    public static void Main()
    {
        sbyte vr0 = (sbyte)((0 & s_2[0][0][0][0, 0].F6) % s_2[0][0][0][0, 0].F6);
    }
}