// Generated by Fuzzlyn on 2018-08-01 00:41:07
// Seed: 17691513820797794397
// Reduced from 43.0 KiB to 0.8 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public uint F2;
    public C0(bool f0, long f1, uint f2)
    {
    }
}

class C1
{
    public C0 F1;
    public C0 F3;
    public C1(C0 f1)
    {
        F1 = f1;
    }
}

class C2
{
    public byte F0;
    public C1 F1;
    public C2(C1 f1)
    {
        F1 = f1;
    }
}

public class Program
{
    static char s_2;
    static C2 s_5 = new C2(new C1(new C0(true, 0, 0)));
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        var vr0 = s_5.F1.F3;
        s_2 = s_2;
        var vr1 = (int)s_5.F1.F1.F2 - (s_5.F0 - s_5.F0);
        M1(vr0, vr1);
    }

    static bool M1(C0 arg0, int arg1)
    {
        arg0 = new C0(false, -4366292108241571178L, 4188812555U);
        return false;
    }
}
