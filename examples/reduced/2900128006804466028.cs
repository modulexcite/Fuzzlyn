// Generated by Fuzzlyn v1.1 on 2018-08-03 21:56:37
// Seed: 2900128006804466028
// Reduced from 212.0 KiB to 1.0 KiB
// Debug: Outputs 0
// Release: Outputs 53947
struct S0
{
    public ushort F0;
    public ulong F2;
    public bool F3;
    public S0(ushort f0): this()
    {
        F0 = f0;
    }
}

struct S1
{
    public S0 F0;
    public int F3;
    public S1(S0 f0): this()
    {
        F0 = f0;
    }
}

class C0
{
    public S0 F3;
    public S1 F4;
    public C0(S1 f4)
    {
        F4 = f4;
    }
}

public class Program
{
    static S1[] s_1 = new S1[]{new S1(new S0(0))};
    static C0 s_34 = new C0(new S1(new S0(0)));
    public static void Main()
    {
        C0 vr6 = new C0(new S1(new S0(53947)));
        var vr7 = s_34.F3;
        var vr8 = vr6.F4.F0;
        M1(vr7, M4(vr8));
    }

    static int M1(S0 arg0, S1 arg1)
    {
        C0 var7 = new C0(new S1(new S0(0)));
        System.Console.WriteLine(arg0.F0);
        return var7.F4.F3;
    }

    static ref S1 M4(S0 arg0)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_1[0];
    }
}
