// Generated by Fuzzlyn on 2018-07-18 06:16:35
// Seed: 8644842280866255326
// Reduced from 51.6 KiB to 0.6 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C1
{
    public bool F4;
}

struct S0
{
    public C1 F3;
    public S0(C1 f3): this()
    {
        F3 = f3;
    }
}

struct S1
{
    public short F2;
    public S0 F4;
    public S1(S0 f4): this()
    {
        F4 = f4;
    }
}

public class Program
{
    static S1[, ] s_5 = new S1[, ]{{new S1(new S0(new C1()))}};
    public static void Main()
    {
        short vr3;
        short vr4 = (sbyte)(0 & s_5[0, 0].F2);
        bool vr5 = s_5[0, 0].F4.F3.F4;
        if (vr5)
        {
            vr3 = vr4;
            System.Console.WriteLine(vr3);
        }
    }
}