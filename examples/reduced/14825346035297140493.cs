// Generated by Fuzzlyn on 2018-06-30 07:42:59
// Seed: 14825346035297140493
// Reduced from 41.0 KiB to 0.5 KiB
// Debug: Outputs 32770
// Release: Outputs 4294934530
struct S0
{
    public short F5;
    public S0(short f5): this()
    {
        F5 = f5;
    }
}

class C0
{
    public short F0;
}

public class Program
{
    static short s_1;
    static C0 s_2 = new C0();
    public static void Main()
    {
        var vr32 = new S0[]{new S0(-32768)};
        s_2.F0 = vr32[0].F5;
        s_1 = s_2.F0;
        var vr38 = (char)(2U | s_1);
        long vr39 = vr38;
        System.Console.WriteLine(vr39);
    }
}
