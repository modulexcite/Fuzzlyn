// Generated by Fuzzlyn on 2018-07-22 22:02:04
// Seed: 1839976888533479711
// Reduced from 89.5 KiB to 0.6 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public short F8;
    public C0(long f1, sbyte f2, uint f5, short f8)
    {
    }
}

struct S0
{
    public C0 F0;
    public S0(C0 f0): this()
    {
        F0 = f0;
    }
}

class C1
{
    public C1(C0 f2, short f6)
    {
    }
}

public class Program
{
    static S0[][, ] s_1 = new S0[][, ]{new S0[, ]{{new S0(new C0(0, 0, 0, 0))}}};
    public static void Main()
    {
        var vr28 = (sbyte)(0 & s_1[0][0, 0].F0.F8);
        var vr29 = s_1[0][0, 0];
        M27(vr28);
    }

    static C1 M27(sbyte arg2)
    {
        return new C1(new C0(0, 0, 0, 0), 0);
    }
}