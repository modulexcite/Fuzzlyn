// Generated by Fuzzlyn v1.1 on 2018-09-12 13:00:34
// Seed: 15282659905147904493
// Reduced from 402.7 KiB to 0.8 KiB in 00:09:04
// Debug: Outputs 0
// Release: Outputs -1
class C0
{
    public sbyte F1;
    public int F4;
    public C0(sbyte f1)
    {
        F1 = f1;
    }
}

class C1
{
    public C0 F0;
    public C1(C0 f0)
    {
        F0 = f0;
    }
}

public class Program
{
    static C1 s_7 = new C1(new C0(0));
    static C1[][] s_31 = new C1[][]{new C1[]{new C1(new C0(-1))}};
    public static void Main()
    {
        sbyte vr14 = s_31[0][0].F0.F1;
        M31(vr14);
    }

    static void M31(sbyte arg0)
    {
        arg0 = (sbyte)s_7.F0.F4;
        arg0 %= -5;
        try
        {
            System.Console.WriteLine(arg0);
        }
        finally
        {
            C0[] var1 = new C0[]{new C0(0), new C0(0), new C0(0), new C0(0), new C0(0)};
        }

        arg0 ^= arg0;
    }
}