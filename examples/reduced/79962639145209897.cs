// Generated by Fuzzlyn v1.1 on 2018-10-02 02:25:13
// Seed: 79962639145209897
// Reduced from 278.6 KiB to 0.9 KiB in 00:06:46
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public long F1;
    public sbyte F2;
    public uint F4;
    public ulong F5;
    public S0(sbyte f2): this()
    {
        F2 = f2;
    }
}

struct S1
{
    public S0 F2;
    public S1(S0 f2): this()
    {
        F2 = f2;
    }
}

public class Program
{
    static bool s_2;
    static S0 s_17 = new S0(1);
    static S1 s_32;
    static short s_39;
    static S1 s_67;
    public static void Main()
    {
        S1 vr4 = default(S1);
        var vr3 = new S1(s_17);
        M44(vr4, M60(M61(vr3, 0), ref s_67));
    }

    static void M44(S1 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F2.F2);
    }

    static ref S0 M60(long arg1, ref S1 arg2)
    {
        uint var1 = s_32.F2.F4;
        return ref arg2.F2;
    }

    static byte M61(S1 arg2, byte arg6)
    {
        if (s_2)
        {
            short var2 = s_39;
        }

        return arg6++;
    }
}