// Generated by Fuzzlyn v1.1 on 2018-08-11 19:53:39
// Seed: 18146418037929707011
// Reduced from 191.8 KiB to 0.6 KiB
// Debug: Outputs 0
// Release: Outputs -93
struct S0
{
}

struct S2
{
    public bool F0;
    public sbyte F2;
    public S0 F3;
    public S2(sbyte f2): this()
    {
        F2 = f2;
    }
}

public class Program
{
    static S2 s_3;
    static S2[] s_6 = new S2[]{new S2(-93)};
    public static void Main()
    {
        M18() = s_6[0];
        M32(ref s_3.F2);
    }

    static ref S2 M18()
    {
        s_6 = new S2[]{new S2(0)};
        return ref s_3;
    }

    static bool M32(ref sbyte arg6)
    {
        System.Console.WriteLine(arg6);
        return s_6[0].F0;
    }
}