// Generated by Fuzzlyn v1.1 on 2018-09-25 07:23:12
// Seed: 4969441596057361984
// Reduced from 270.9 KiB to 0.5 KiB in 00:03:32
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public ushort F0;
    public uint F1;
    public byte F3;
    public long F6;
    public S0(uint f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    static S0 s_1;
    public static void Main()
    {
        var vr3 = new S0(0);
        var vr4 = new S0(1);
        var vr5 = new S0(0);
        M18(vr3, M18(vr4, vr5));
    }

    static ref S0 M18(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F1);
        return ref s_1;
    }
}
