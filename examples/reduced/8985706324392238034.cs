// Generated by Fuzzlyn on 2018-07-09 02:04:17
// Seed: 8985706324392238034
// Reduced from 120.6 KiB to 0.4 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public int F0;
}

struct S0
{
    public sbyte F0;
    public C0 F5;
    public S0(C0 f5): this()
    {
        F5 = f5;
    }
}

public class Program
{
    static S0[][, ] s_3 = new S0[][, ]{new S0[, ]{{new S0(new C0())}}};
    public static void Main()
    {
        int vr3 = 0 & s_3[0][0, 0].F0;
        s_3[0][0, 0].F5.F0 = 0;
        System.Console.WriteLine(vr3);
    }
}
