// Generated by Fuzzlyn v1.1 on 2018-08-09 14:06:37
// Seed: 15118603990292054906
// Reduced from 30.9 KiB to 0.8 KiB
// Debug: Outputs 0
// Release: Outputs -933765028
struct S0
{
    public int F0;
    public short F2;
    public sbyte F3;
    public int F5;
    public S0(int f0): this()
    {
        F0 = f0;
    }
}

class C0
{
    public S0 F0;
    public S0 F1;
    public C0(S0 f1)
    {
        F1 = f1;
    }
}

public class Program
{
    static byte s_3;
    static C0[] s_7 = new C0[]{new C0(new S0(-933765028))};
    public static void Main()
    {
        M9(ref s_7[0], M8(ref s_7)) = s_7[0].F1;
        ref C0 vr8 = ref s_7[0];
        System.Console.WriteLine(vr8.F1.F0);
    }

    static byte M8(ref C0[] arg1)
    {
        arg1[0] = new C0(new S0(0));
        return s_3;
    }

    static ref S0 M9(ref C0 arg1, short arg2)
    {
        arg1.F0.F2 = (short)(0 & (arg1.F1.F3 ^ arg1.F1.F5));
        return ref arg1.F1;
    }
}