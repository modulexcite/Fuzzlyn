// Generated by Fuzzlyn v1.1 on 2018-09-05 09:00:26
// Seed: 5202455726898864249
// Reduced from 296.7 KiB to 0.7 KiB in 00:04:55
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public byte F0;
    public long F1;
    public byte F4;
    public S0(byte f4): this()
    {
        F4 = f4;
    }
}

struct S1
{
    public S0 F3;
}

public class Program
{
    static S1 s_28;
    static S1 s_69;
    public static void Main()
    {
        var vr2 = new S0(1);
        bool vr3 = M31(vr2, M73(s_28));
    }

    static bool M31(S0 arg0, S0 arg1)
    {
        S1 var1;
        var1.F3.F4 = arg0.F4;
        System.Console.WriteLine(var1.F3.F4);
        bool vr12 = default(bool);
        return vr12;
    }

    static ref S0 M73(S1 arg0)
    {
        sbyte[] var0 = new sbyte[]{1, 1};
        return ref s_69.F3;
    }
}
