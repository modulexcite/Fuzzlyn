// Generated by Fuzzlyn v1.1 on 2018-09-10 15:20:54
// Seed: 3086361031133528751
// Reduced from 85.3 KiB to 0.5 KiB in 00:01:32
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public uint F0;
    public int F1;
    public ushort F6;
    public ulong F7;
    public S0(uint f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_11;
    public static void Main()
    {
        var vr3 = new S0(1);
        var vr4 = new S0(0);
        var vr5 = new S0(0);
        M26(vr3, M26(vr4, vr5));
    }

    static ref S0 M26(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_11;
    }
}